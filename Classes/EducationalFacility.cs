using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class EducationalFacility
    {
        private int idFAcility;
        private string inn;
        private string name;

        public EducationalFacility()
        {
            idFAcility = 0;
            inn = null;
            name = null;
        }

        public EducationalFacility(int _idFacility, string _inn, string _name)
        {
            idFAcility = _idFacility;
            inn = _inn;
            name = _name;
        }

        public int IdFacility
        {
            get { return idFAcility; }
            set { idFAcility = value; }
        }

        public string Inn
        {
            get { return inn; }
            set { inn = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
