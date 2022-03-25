using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class Faculty
    {
        private int idFaculty;
        private string nameFaculty;
        private int educationFacility;

        public Faculty()
        {
            idFaculty = 0;
            nameFaculty = null;
            educationFacility = 0;
        }

        public Faculty(int _idFaculty, string _nameFaculty, int _facility)
        {
            idFaculty = _idFaculty;
            nameFaculty = _nameFaculty;
            educationFacility = _facility;
        }

        public int IdFaculty
        {
            get { return idFaculty; }
            set { idFaculty = value; }
        }

        public string NameFaculty
        {
            get { return nameFaculty; }
            set { nameFaculty = value; }
        }

        public int EducationFacility
        {
            get { return educationFacility; }
            set { educationFacility = value; }
        }
    }
}
