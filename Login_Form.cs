using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Projects_of_students
{
    public partial class Login_Form : Form
    {
        private bool isStudent = true;
        SqlConnection connection = new SqlConnection();
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Projects\IS Projects of students\Database1.mdf"";Integrated Security=True";
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputLogin_TextChanged(object sender, EventArgs e)
        {
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

        private void loginAsTeacher_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Khaki;
        }

        private void loginAsTeacher_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.White;
        }

        private void loginAsTeacher_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Orange;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            inputPassword.UseSystemPasswordChar = !inputPassword.UseSystemPasswordChar;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginAsTeacher_Click(object sender, EventArgs e)
        {
            if (isStudent)
            {
                loginAsTeacher.Text = "Войти как студент";
            }
            else
            {
                loginAsTeacher.Text = "Войти как преподаватель";
            }
            isStudent = !isStudent;
        }
        public void checkLogin()
        {
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command;
                string login = inputLogin.Text;
                string passworld = inputPassword.Text;

                if (isStudent)
                {
                    command = new SqlCommand($"SELECT [Login], [Password] FROM Students WHERE [Login] = {login.ToLower()} AND [Password] = {passworld}");
                }
                else
                {
                    command = new SqlCommand($"SELECT [Login], [Password] FROM Teachers WHERE [Login] = {login.ToLower()} AND [Password] = {passworld}");
                }

                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MainMenu form = new MainMenu();
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
