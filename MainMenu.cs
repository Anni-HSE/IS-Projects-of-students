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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(bool isStudent)
        {
            InitializeComponent();
            if(isStudent)
            {
                menuStripTeacher.Enabled = false;
                menuStripTeacher.Visible = false;
                menuStripStudent.Enabled = true;
                menuStripStudent.Visible = true;
            }
            else
            {
                menuStripTeacher.Enabled = true;
                menuStripTeacher.Visible = true;
                menuStripStudent.Enabled = false;
                menuStripStudent.Visible = false;
            }
        }

        private void toolStripTextBox43_Click(object sender, EventArgs e)
        {
            StudentInformation form = new StudentInformation();
            form.Show();
        }
    }
}
