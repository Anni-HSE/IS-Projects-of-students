using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class StudentsProjects
    {
        public int project;
        public int student;
        public string comment;
        public string solutionTask;
        public DateTime dateOfDowland;
        public int note;

        public StudentsProjects()
        {
            project = 0;
            student = 0;
            comment = "";
            solutionTask = "";
            dateOfDowland = new DateTime();
            note = 0;
        }
    }
}
