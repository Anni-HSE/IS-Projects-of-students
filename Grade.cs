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
    public partial class Grade : Form
    {
        private object[] projectIds;

        public Grade()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            selectedIdStudent.Items.AddRange(QueriesForSQL.GetStudentIds());
        }

        private void selectedIdStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIdProject.Items.Clear();
            selectedIdProject.Items.AddRange(QueriesForSQL.GetstudentProjects(Convert.ToInt32(selectedIdStudent.SelectedItem) + 1));
        }

        private void selectedIdProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void createNewProject_Click(object sender, EventArgs e)
        {
            if (selectedGrade.SelectedIndex != -1)
            {
                QueriesForSQL.UpdateStudentProject(Convert.ToInt32(selectedIdStudent.SelectedItem) + 1, Convert.ToInt32(selectedIdProject.SelectedItem) + 1, Convert.ToInt32(selectedGrade.SelectedItem));
                MessageBox.Show("Вы поставили оценку", "Постваить оценку", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("Вы не поставили оценку", "Постваить оценку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
