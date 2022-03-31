using IS_Projects_of_students.Classes;
using IS_Projects_of_students.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Projects_of_students
{
    public partial class Grade : Form
    {
        private int idStudent;
        private int idProject;
        private object[] projectTypes;
        private List<StudentsProjects> projectsStudents;


        public Grade()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            selectedIdStudent.Items.Clear();
            selectedIdStudent.Items.AddRange(QueriesForSQL.GetstudentsFIO());

            selectedIdProject.Items.Clear();
            selectedIdProject.Items.AddRange(QueriesForSQL.GetProjectNames());

            DowlandData();
            dowlandDatainGridView();
        }

        private void selectedIdStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            idStudent = QueriesForSQL.GetStudentIdUseFio(selectedIdStudent.SelectedItem.ToString());
        }

        private void selectedIdProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProject = QueriesForSQL.GetProjectId(selectedIdStudent.SelectedItem.ToString());
            if (QueriesForSQL.CheckStudentProject(idStudent, idProject) == 0)
            {
                addProjectForStudent.Enabled = true;
                writeDecription.Enabled = false;
                writeCommentary.Enabled = false;
                inputSolutionTask.Enabled = false;
                numericUpDown1.Enabled = false;
                addGrade.Enabled = false;
            }
            else
            {
                addProjectForStudent.Enabled = false;
                writeDecription.Enabled = false;
                writeCommentary.Enabled = true;
                inputSolutionTask.Enabled = false;
                numericUpDown1.Enabled = true;
                addGrade.Enabled = true;

                writeDecription.Text = QueriesForSQL.GetDescriptionProject(idProject);
                writeDecription.Text = QueriesForSQL.GetComment(idProject, idStudent);
                inputSolutionTask.Text = QueriesForSQL.GetSolutionTask(idProject, idStudent);
            }
        }

        private void dowlandDatainGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (StudentsProjects projects in projectsStudents)
            {
                string fio = QueriesForSQL.GetstudentFIO(projects.student);
                Project project = QueriesForSQL.GetProject(projects.project);
                int note = QueriesForSQL.GetNote(projects.project, projects.student);
                string solutiontars = QueriesForSQL.GetSolutionTask(projects.project, projects.student);
                DateTime dowland = QueriesForSQL.GetDowlandDate(projects.project, projects.student);

                string date = "";
                if (dowland == new DateTime())
                    date = "";
                else
                    date = dowland.ToString();

                dataGridView1.Rows.Add(fio, project.NameProject, projectTypes[project.TypeProject - 1].ToString(), project.Deadline, solutiontars, date, note);
            }

            dataGridView1.Refresh();
        }

        private void DowlandData()
        {
            projectsStudents = QueriesForSQL.GetStudentsProjects();
            projectTypes = QueriesForSQL.GetProjectTypes();
        }

        private void addProjectForStudent_Click(object sender, EventArgs e)
        {
            if(QueriesForSQL.CreateStudentProject(idStudent, idProject) != -1)
            {
                MessageBox.Show("Проект назначен студенту", "Назначение проекта студенту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DowlandData();
                dowlandDatainGridView();

                addProjectForStudent.Enabled = false;
                writeDecription.Enabled = false;
                writeCommentary.Enabled = true;
                inputSolutionTask.Enabled = false;
                numericUpDown1.Enabled = true;
                addGrade.Enabled = true;
            }
            else
            {
                MessageBox.Show("Проект не назначен студенту", "Назначение проекта студенту", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addGrade_Click(object sender, EventArgs e)
        {
            QueriesForSQL.UpdateGrade(idStudent, idProject, writeCommentary.Text, Convert.ToInt32(numericUpDown1.Value));

            MessageBox.Show("Оценка и комментарий добавлены студенту", "оценивание проекта студента", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DowlandData();
            dowlandDatainGridView();
        }
    }
}
