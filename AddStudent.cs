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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            inputGender.Items.AddRange(QueriesForSQL.GetGenders());
            inputGroup.Items.AddRange(QueriesForSQL.GetGroups());
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
                MessageBox.Show("Ошибка. Неверная длина логина. Минимальная длина = 4, максимальная = 20", "Добавление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputEmail.Text.Length == 0)
            {
                MessageBox.Show("Ошибка. Вы не веели почту", "Добавление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputFIO.Text.Length == 0)
            {
                MessageBox.Show("Ошибка. Вы не веели ФИО", "Добавление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputGender.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали пол", "Добавление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали группу", "Добавление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (QueriesForSQL.CheckLogin(inputLogin.Text, inputGroup.SelectedItem.ToString()))
            {
                MessageBox.Show("Ошибка. Такой логин уже занят.", "Добавление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            if(checkData())
            {
                string password = "qwe123";
                var fio = inputFIO.Text.Split(' ');
                Student student = new Student();
                student.Login = inputLogin.Text;
                student.Password = password;
                student.FatherName = fio[2];
                student.FirstName = fio[0];
                student.SecondName = fio[1];
                student.Email = inputEmail.Text;
                student.DataOfBirthday = inputDoB.Value;
                student.DataOfBirthday = DateTime.Now;
                student.Gender = inputGender.SelectedIndex + 1;
                student.IdGroup = inputGroup.SelectedIndex + 1;

                if (QueriesForSQL.CreateStudent(student) != -1)
                {
                    MessageBox.Show("Студент добавлен", "Добавление студента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Студент не добавлен", "Добавление студента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Close();
            }
        }
    }
}
