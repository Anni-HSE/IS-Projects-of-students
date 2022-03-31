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
using System.Reflection;

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

                dataGridView1.Rows.Add(student.Login, student.Email, student.FirstName, student.SecondName, student.FatherName, student.DataOfBirthday, student.DataOfRegistration, gender, group);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
