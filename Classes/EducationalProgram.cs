using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class EducationalProgram
    {
        private int idProgram;
        private string nameProgram;
        private int faculty;

        public EducationalProgram()
        {
            idProgram = 0;
            nameProgram = null;
            faculty = 0;
        }

        public EducationalProgram(int id, string name, int _faculty)
        {
            idProgram = id;
            nameProgram = name;
            faculty = _faculty;
        }

        public int IdProgram
        {
            get { return idProgram; }
            set { idProgram = value; }
        }

        public string NameProgram
        {
            get { return nameProgram; }
            set { nameProgram = value; }
        }

        public int Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
    }
}
