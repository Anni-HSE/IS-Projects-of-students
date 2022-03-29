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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            selectedSubject.Items.AddRange(QueriesForSQL.GetSubjects());
            selectedType.Items.AddRange(QueriesForSQL.GetProjectTypes());
        }

        public bool checkData()
        {
            if (inputNameProject.Text.Length == 0)
            {
                MessageBox.Show("Ошибка. Вы не веели название проекта", "Добавление проекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputDescription.Text.Length == 0)
            {
                MessageBox.Show("Ошибка. Вы не веели описание проекта", "Добавление проекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (selectedType.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали тип проекта", "Добавление проекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (selectedSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали предмет, к которому относится проект", "Добавление проекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (QueriesForSQL.CheckNameProject(inputNameProject.Text))
            {
                MessageBox.Show("Ошибка. Такой проект уже существует", "Добавление проекта ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void createNewProject_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                Project project = new Project();

                project.NameProject = inputNameProject.Text;
                project.DescriptionProject = inputDescription.Text;
                project.Deadline = inputDeadline.Value;
                project.Subject = selectedSubject.SelectedIndex + 1;
                project.TypeProject = selectedType.SelectedIndex + 1;

                if (QueriesForSQL.CreateProject(project) != -1)
                {
                    MessageBox.Show("Проект добавлен", "Добавление проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Проект не добавлен", "Добавление проекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
