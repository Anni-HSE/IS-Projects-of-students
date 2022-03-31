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
    public partial class UpdateAndRemoveStudent : Form
    {
        private List<Student> students = new List<Student>();
        private object[] genders;
        private object[] groups;
        private object[] ids;

        public UpdateAndRemoveStudent()
        {
            InitializeComponent();
        }

        private void UpdateAndRemoveStudent_Load(object sender, EventArgs e)
        {
            students = QueriesForSQL.GetStudents();
            genders = QueriesForSQL.GetGenders();
            groups = QueriesForSQL.GetGroups();
            ids = QueriesForSQL.GetStudentIds();

            inputGender.Items.AddRange(genders);
            inputGroup.Items.AddRange(groups);
            selectedId.Items.AddRange(ids);

            dowlandDatainGridView();
            dataGridView1.Refresh();
        }

        private void dowlandDatainGridView()
        {
            foreach (Student student in students)
            {
                string gender = genders[student.Gender - 1].ToString();
                string group;
                if (student.IdGroup != 0)
                    group = groups[student.IdGroup - 1].ToString();
                else
                    group = "";

                dataGridView1.Rows.Add(student.Login, student.Email, student.FirstName, student.SecondName, student.FatherName, student.DataOfBirthday, student.DataOfRegistration, gender, group);
            }
        }

        private void inputLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputLogin.Text.Length == 0 && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 65 || e.KeyChar > 89) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (inputLogin.Text.Length >= 0 && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 65 || e.KeyChar > 89) && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 95 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void inputPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 33 || e.KeyChar > 126) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public bool checkData()
        {
            if (!(inputLogin.Text.Length >= 4 && inputLogin.Text.Length <= 20))
            {
                MessageBox.Show("Ошибка. Неверная длина логина. Минимальная длина = 4, максимальная = 20", "Обновление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(inputPassword.Text.Length >= 4 && inputPassword.Text.Length <= 20))
            {
                MessageBox.Show("Ошибка. Неверная длина пароля. Минимальная длина = 4, максимальная = 20", "Обновление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputEmail.Text.Length == 0)
            {
                MessageBox.Show("Ошибка. Вы не веели почту", "Обновление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputFIO.Text.Length == 0)
            {
                MessageBox.Show("Ошибка. Вы не веели ФИО", "Обновление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputGender.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали пол", "Обновление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали группу", "Обновление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                if (selectedId.SelectedIndex == -1)
                {
                    MessageBox.Show("Ошибка. Вы не выбрали студента", "Обновление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var fio = inputFIO.Text.Split(' ');
                    Student student = new Student();
                    student.Password = inputPassword.Text;
                    student.FatherName = fio[2];
                    student.FirstName = fio[0];
                    student.SecondName = fio[1];
                    student.Email = inputEmail.Text;
                    student.DataOfBirthday = inputDoB.Value;
                    student.Gender = inputGender.SelectedIndex + 1;
                    student.IdGroup = inputGroup.SelectedIndex + 1;

                    QueriesForSQL.UpdateStudnent(Convert.ToInt32(selectedId.SelectedItem.ToString()), student);

                    MessageBox.Show("Студент обновлен", "Обновление студента", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    students = QueriesForSQL.GetStudents();

                    dataGridView1.Rows.Clear();
                    dowlandDatainGridView();
                    dataGridView1.Refresh();
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedId.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали студента", "Удаление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QueriesForSQL.RemoveStudent(Convert.ToInt32(selectedId.SelectedItem.ToString()));
                MessageBox.Show("Студент удален", "Удаление студента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                students = QueriesForSQL.GetStudents();
                
                dataGridView1.Rows.Clear();
                dowlandDatainGridView();
                dataGridView1.Refresh();

                selectedId.Text = "";
                selectedId.Items.Clear();
                selectedId.Items.AddRange(QueriesForSQL.GetStudentIds());
            }
        }

        private void selectedId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = QueriesForSQL.GetStudent(Convert.ToInt32(selectedId.SelectedItem));
            inputLogin.Text = student.Login;
            inputPassword.Text = student.Password;
            inputFIO.Text = student.SecondName + " " + student.FirstName + " " + student.FatherName;
            inputEmail.Text = student.Email;
            inputGender.SelectedIndex = student.Gender - 1;
            if(student.IdGroup != 0)
                inputGroup.SelectedIndex = student.IdGroup - 1;
            inputDoB.Value = student.DataOfBirthday;
        }
    }
}
