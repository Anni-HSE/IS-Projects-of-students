using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class Group
    {
        private int idGroup;
        private string nameGroup;
        private int program;

        public Group()
        {
            idGroup = 0;
            nameGroup = null;
            program = 0;
        }

        public Group(int id, string name, int _program)
        {
            idGroup = id;
            nameGroup = name;
            program = _program;
        }

        public int IdGroup
        {
            get { return idGroup; }
            set { idGroup = value; }
        }

        public string NameGroup
        {
            get { return nameGroup; }
            set { nameGroup = value; }
        }

        public int Program
        {
            get { return program; }
            set { program = value; }
        }
    }
}
