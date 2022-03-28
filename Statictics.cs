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
    public partial class Statictics : Form
    {
        public Statictics()
        {
            InitializeComponent();
        }

        private void Statictics_Load(object sender, EventArgs e)
        {
            manGender.Text = "Студентов мужского пола = " + QueriesForSQL.GetCountOfMaleStudent();
            womanGender.Text = "Студентов женского пола = " + QueriesForSQL.GetCountOfFemaleStudent();
            allGender.Text = "Всего студентов = " + QueriesForSQL.GetCountStudents();
        }
    }
}
