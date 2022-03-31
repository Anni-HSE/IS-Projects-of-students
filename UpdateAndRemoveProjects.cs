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
    public partial class UpdateAndRemoveProjects : Form
    {
        private List<Project> projects = new List<Project>();
        private object[] projectTypes;
        private object[] subjects;
        private object[] departmentsId;
        private object[] departments;
        private object[] facilitiesId;
        private object[] facilities;

        public UpdateAndRemoveProjects()
        {
            InitializeComponent();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                if (selectedId.SelectedIndex == -1)
                {
                    MessageBox.Show("Ошибка. Вы не выбрали проект", "Обновление проекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Project project = new Project();

                    project.NameProject = inputNameProject.Text;
                    project.DescriptionProject = inputDescription.Text;
                    project.Deadline = inputDeadline.Value;
                    project.Subject = selectedSubject.SelectedIndex + 1;
                    project.TypeProject = selectedType.SelectedIndex + 1;

                    QueriesForSQL.UpdateProject(Convert.ToInt32(selectedId.SelectedItem.ToString()), project);

                    MessageBox.Show("Проект обновлен", "Обновление проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    projects = QueriesForSQL.GetProjects();

                    dowlandDatainGridView();
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedId.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали проект", "Удаление проекта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QueriesForSQL.RemoveProject(Convert.ToInt32(selectedId.SelectedItem.ToString()));
                MessageBox.Show("Проект удален", "Удаление проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);

                projects = QueriesForSQL.GetProjects();

                dataGridView1.Rows.Clear();
                dowlandDatainGridView();
                dataGridView1.Refresh();

                selectedId.Items.Clear();
                selectedId.Items.AddRange(QueriesForSQL.GetProjectIds());
            }
        }

        private void dowlandDatainGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Project project in projects)
            {
                dataGridView1.Rows.Add(project.NameProject, project.DescriptionProject, projectTypes[project.TypeProject - 1].ToString(), project.Deadline, subjects[project.Subject - 1].ToString(),
                    departments[Convert.ToInt32(departmentsId[project.Subject - 1]) - 1].ToString(), facilities[Convert.ToInt32(facilitiesId[Convert.ToInt32(departmentsId[project.Subject - 1]) - 1]) - 1].ToString());
            }
            dataGridView1.Refresh();
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

        private void selectedId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project project = QueriesForSQL.GetProject(Convert.ToInt32(selectedId.SelectedItem));
            inputNameProject.Text = project.NameProject;
            inputDescription.Text = project.DescriptionProject;
            selectedSubject.SelectedIndex = project.Subject - 1;
            selectedType.SelectedIndex = project.TypeProject - 1;
            inputDeadline.Value = project.Deadline;
        }

        private void UpdateAndRemoveProjects_Load(object sender, EventArgs e)
        {
            projects = QueriesForSQL.GetProjects();
            projectTypes = QueriesForSQL.GetProjectTypes();
            subjects = QueriesForSQL.GetSubjects();
            departments = QueriesForSQL.GetDepartments();
            departmentsId = QueriesForSQL.GetDepartmentsId();
            facilities = QueriesForSQL.GetFacilities();
            facilitiesId = QueriesForSQL.GetFacilitiesId();

            selectedSubject.Items.AddRange(QueriesForSQL.GetSubjects());
            selectedType.Items.AddRange(QueriesForSQL.GetProjectTypes());
            selectedId.Items.AddRange(QueriesForSQL.GetProjectIds());

            dowlandDatainGridView();
        }
    }
}
