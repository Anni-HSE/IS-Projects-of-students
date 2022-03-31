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
    public partial class StudentInformation : Form
    {
        private string login;
        private Student student;
        private object[] genders;
        private object[] groups;

        public StudentInformation()
        {
            InitializeComponent();
        }

        public StudentInformation(string _login)
        {
            InitializeComponent();
            login = _login;
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            student = QueriesForSQL.GetStudent(login);
            genders = QueriesForSQL.GetGenders();
            groups = QueriesForSQL.GetGroups();
            PrintStudentInformation();
            DisableFields();
        }

        private void PrintStudentInformation()
        {
            writeLogin.Text = student.Login;
            writeFIO.Text = student.SecondName + " " + student.FirstName + " " + student.FatherName;
            writeEmail.Text = student.Email;
            writeDoB.Value = student.DataOfBirthday;
            writeDoR.Value = student.DataOfRegistration;
            writeGender.Text = genders[student.Gender - 1].ToString();

            if(student.IdGroup != 0)
            {
                writeGroup.Text = groups[student.IdGroup - 1].ToString();
            }
        }

        private void DisableFields()
        {
            writeLogin.Enabled = false;
            writeFIO.Enabled = false;
            writeEmail.Enabled = false;
            writeDoR.Enabled = false;
            writeDoB.Enabled = false;
            writeGender.Enabled = false;
            writeGroup.Enabled = false;
        }
    }
}
