﻿using System;
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
        private string login;
        private bool isStudent;
      
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(bool _isStudent, string _login)
        {
            InitializeComponent();
            if(_isStudent)
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

            login = _login;
            isStudent = _isStudent;
        }

        private void toolStripTextBox43_Click(object sender, EventArgs e)
        {
            StudentInformation form = new StudentInformation(login);
            form.Show();
        }
        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            ShowStudents form = new ShowStudents();
            form.Show();
        }

        public string Login
        {
            get
            {
                return login;
            }
        }

        public bool IsStudent
        {
            get
            {
                return isStudent;
            }
        }

    }
}
