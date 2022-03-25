﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Projects_of_students
{
    public partial class Registration : Form
    {
        SqlCommand command = new SqlCommand();
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\\Projects\\IS Projects of students\\Database1.mdf"";Integrated Security=True";
        int number;
        List<string> genders = new List<string>();

        public Registration()
        {
            InitializeComponent();
        }

        private void inputLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showPassword_CheckStateChanged(object sender, EventArgs e)
        {        
            inputPassword.UseSystemPasswordChar = !inputPassword.UseSystemPasswordChar;
            inputConfirmPassword.UseSystemPasswordChar = !inputConfirmPassword.UseSystemPasswordChar;    
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

        private void Registration_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                command = new SqlCommand($"SELECT NameGender FROM Genders");
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        genders.Add(dataReader["NameGender"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                inputGender.Items.AddRange(genders.ToArray());
            }
        }
        public void createAccount()
        {

            string login = inputLogin.Text.ToLower();
            string password = inputPassword.Text;
            string email = inputEmail.Text;
            var fio = inputFIO.Text.Split(' ');
            int gender = inputGender.SelectedIndex + 1;
            DateTime dob = inputDoB.Value;
            DateTime dor = DateTime.Now;

            string values = $"values (\'{login}\','{password}\','{fio[0]}\','{fio[1]}\','{fio[2]}\',\'{dob}\',\'{dor}\',\'{email}\', {gender})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (inputTypePerson.SelectedItem as string == "Студент")
                {
                    command = new SqlCommand($"INSERT INTO Students ([Login], [Password], [FirstName], [SecondName], [FatherName], [DataOfBirthday], [DataOfRegistration], [Email], [Gender]) " + values);
                }
                else
                {
                    command = new SqlCommand($"INSERT INTO Teathers ([Login], [Password], [FirstName], [SecondName], [FatherName], [DataOfBirthday], [DataOfRegistration], [Email], [Gender]) " + values);
                }

                try
                {
                    number = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool checkData()
        {
            if (!(inputLogin.Text.Length >= 4 && inputLogin.Text.Length <= 20))
            {
                MessageBox.Show("Ошибка. Неверная длина логина. Минимальная длина = 4, максимальная = 20", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(inputPassword.Text.Length >= 4 && inputPassword.Text.Length <= 20))
            {
                MessageBox.Show("Ошибка. Неверная длина пароля. Минимальная длина = 4, максимальная = 20", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputPassword.Text != inputConfirmPassword.Text)
            {
                MessageBox.Show("Ошибка. Пароли не совпадают", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputEmail.Text.Length == 0)
            {
                MessageBox.Show("Ошибка. Вы не веели почту", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputFIO.Text.Length == 0)
            {
                MessageBox.Show("Ошибка. Вы не веели ФИО", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputGender.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали пол", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputTypePerson.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Вы не выбрали тип аккаунта", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inputTypePerson.SelectedItem.ToString() == "Студент")
            {
                command = new SqlCommand($"SELECT [Login] FROM Students WHERE [Login] = {inputLogin.Text.ToLower()}");
            }
            else
            {
                command = new SqlCommand($"SELECT [Login] FROM Teachers WHERE [Login] = {inputLogin.Text.ToLower()}");
            }

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                MessageBox.Show("Ошибка. Такой логин уже занят.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                createAccount();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
