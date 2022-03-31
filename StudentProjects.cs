using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using IS_Projects_of_students.Classes;
using IS_Projects_of_students.Scripts;

namespace IS_Projects_of_students
{
    public partial class StudentProjects : Form
    {
        private int idStudent;
        private string login;
        private object[] subjects;
        private object[] projectTypes;
        private List<StudentsProjects> projectsStudents;
        private List<Project> projects;

        public StudentProjects()
        {
            InitializeComponent();
        }

        public StudentProjects(string _login)
        {
            InitializeComponent();
            login = _login;
        }

        private void StudentProjects_Load(object sender, EventArgs e)
        {
            DowlandData();
            NewRangeForSelectedSubjects();
            NewRangeForSelectedProjects();
            dowlandDatainGridView();
        }

        private void NewRangeForSelectedSubjects()
        {
            selectedSubject.Items.Clear();

            foreach (Project project in projects)
            {
                selectedSubject.Items.Add(subjects[project.Subject - 1]);
            }
        }

        private void NewRangeForSelectedProjects()
        {
            selectedProject.Items.Clear();

            foreach (Project project in projects)
            {
                selectedProject.Items.Add(project.NameProject);
            }
        }

        private void dowlandDatainGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (Project project in projects)
            {
                int note = QueriesForSQL.GetNote(project.IdProject, idStudent);
                string solutiontars = QueriesForSQL.GetSolutionTask(project.IdProject, idStudent);
                DateTime dowland = QueriesForSQL.GetDowlandDate(project.IdProject, idStudent);

                string date = "";
                if (dowland == new DateTime())
                    date = ""; 
                else
                    date = dowland.ToString();

                dataGridView1.Rows.Add(project.NameProject, projectTypes[project.TypeProject - 1].ToString(), project.Deadline, solutiontars, date, note);
            }

            dataGridView1.Refresh();
        }

        private void selectedProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProject = QueriesForSQL.GetProjectId(selectedProject.SelectedItem.ToString());
            writeDecription.Text = QueriesForSQL.GetDescriptionProject(idProject);
            writeCommentary.Text = QueriesForSQL.GetComment(idProject, idStudent);
            inputSolutionTask.Text = QueriesForSQL.GetSolutionTask(idProject, idStudent);

            if(inputSolutionTask.Text == "")
            {
                addSolution.Enabled = true;
                updateSolution.Enabled = false;
            }
            else
            {
                addSolution.Enabled = false;
                updateSolution.Enabled = true;
            }
        }

        private void DowlandData()
        {
            subjects = QueriesForSQL.GetSubjects();
            idStudent = QueriesForSQL.GetStudentId(login);
            projectsStudents = QueriesForSQL.GetStudentsProjects(idStudent);
            projects = QueriesForSQL.GetProjects(projectsStudents);
            projectTypes = QueriesForSQL.GetProjectTypes();
        }

        private void addSolution_Click(object sender, EventArgs e)
        {
            int idProject = QueriesForSQL.GetProjectId(selectedProject.SelectedItem.ToString());
            QueriesForSQL.UpdateSolutionTask(idProject, idStudent, inputSolutionTask.Text);

            MessageBox.Show("Решение добавлено", "Д обавление решения к проекту", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dowlandDatainGridView();
        }

        private void updateSolution_Click(object sender, EventArgs e)
        {
            int idProject = QueriesForSQL.GetProjectId(selectedProject.SelectedItem.ToString());
            QueriesForSQL.UpdateSolutionTask(idProject, idStudent, inputSolutionTask.Text);

            MessageBox.Show("Решение обновлено", "обновление решения к проекту", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dowlandDatainGridView();
        }
    }
}
