using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IS_Projects_of_students.Classes;
using IS_Projects_of_students.Scripts;

namespace IS_Projects_of_students
{
    public partial class ShowProjects : Form
    {
        private List<Project> projects = new List<Project>();
        private object[] projectTypes;
        private object[] subjects;
        private object[] departmentsId;
        private object[] departments;
        private object[] facilitiesId;
        private object[] facilities;

        public ShowProjects()
        {
            InitializeComponent();         
        }

        private void ShowProjects_Load(object sender, EventArgs e)
        {
            projects = QueriesForSQL.GetProjects();
            projectTypes = QueriesForSQL.GetProjectTypes();
            subjects = QueriesForSQL.GetSubjects();
            departments = QueriesForSQL.GetDepartments();
            departmentsId = QueriesForSQL.GetDepartmentsId();
            facilities = QueriesForSQL.GetFacilities();
            facilitiesId = QueriesForSQL.GetFacilitiesId();

            dowlandDatainGridView();
        }

        private void dowlandDatainGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Project project in projects)
            {
                dataGridView1.Rows.Add(project.IdProject, project.NameProject, project.DescriptionProject, projectTypes[project.TypeProject - 1].ToString(), project.Deadline, subjects[project.Subject - 1].ToString(),
                    departments[Convert.ToInt32(departmentsId[project.Subject - 1]) - 1].ToString(), facilities[Convert.ToInt32(facilitiesId[Convert.ToInt32(departmentsId[project.Subject - 1]) - 1]) - 1].ToString());
            }
            dataGridView1.Refresh();
        }
    }
}
