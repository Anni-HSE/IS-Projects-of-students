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
        private object[] files;
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
                DateTime dateOfDowland = QueriesForSQL.GetDowlandDate(project.IdProject);

                dataGridView1.Rows.Add(project.NameProject, projectTypes[project.TypeProject - 1].ToString(), project.Deadline, dateOfDowland.ToString(), note);
            }

            dataGridView1.Refresh();
        }

        private void selectedProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProject = QueriesForSQL.GetProjectId(selectedProject.SelectedItem.ToString());
            writeDecription.Text = QueriesForSQL.GetDescriptionProject(idProject);
            writeComentary.Text = QueriesForSQL.GetComment(idProject, idProject);
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            string[] data = File.ReadAllLines(filePath);
            XElement root = new XElement("root", from item in data select new XElement("Line", item));

            QueriesForSQL.DowlandFile(root);

            MessageBox.Show("Файл загружен", "Заугрузка файла", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DowlandData();
            dowlandDatainGridView();
        }

        private void DowlandData()
        {
            subjects = QueriesForSQL.GetSubjects();
            idStudent = QueriesForSQL.GetStudentId(login);
            projectsStudents = QueriesForSQL.GetStudentsProjects(idStudent);
            projects = QueriesForSQL.GetProjects(projectsStudents);
            projectTypes = QueriesForSQL.GetProjectTypes();
        }
    }
}
