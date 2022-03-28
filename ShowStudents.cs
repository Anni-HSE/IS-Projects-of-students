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
    public partial class ShowStudents : Form
    {
        private List<Student> students = new List<Student>();
        private object[] genders;
        private object[] groups;

        public ShowStudents()
        {
            InitializeComponent();
        }

        private void ShowStudents_Load(object sender, EventArgs e)
        {
            students = QueriesForSQL.GetStudents();
            genders = QueriesForSQL.GetGenders();
            groups = QueriesForSQL.GetGroups();

            dowlandDatainGridView();
            dataGridView1.Refresh();
        }

        private void dowlandDatainGridView()
        {
            foreach(Student student in students)
            {
                string gender = genders[student.Gender - 1].ToString();
                string group;
                if (student.IdGroup != 0)
                    group = groups[student.IdGroup - 1].ToString();
                else
                    group = "";

                dataGridView1.Rows.Add(student.IdStudent, student.Login, student.Email, student.FirstName, student.SecondName, student.FatherName, student.DataOfBirthday, student.DataOfRegistration, gender, group);
            }
        }
    }
}
