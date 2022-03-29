using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class Project
    {
        private int idProject;
        private string nameProject;
        private string descrptionProject;
        private int typeProject;
        private DateTime deadline;
        private int subject;

        public Project()
        {
            idProject = 0;
            nameProject = null;
            descrptionProject = null;
            typeProject = 0;
            deadline = new DateTime();
            subject = 0;
        }

        public Project(int _idProject, string _name, string _descrption, int _studentId, int _typeProject, int _typeSubject, DateTime _deadline, string _pathFile, int _subject)
        {
            idProject = _idProject;
            nameProject = _name;
            descrptionProject = _descrption;
            typeProject = _typeProject;
            deadline = _deadline;
            subject = _subject;
        }

        public int IdProject
        {
            get { return idProject; }
            set { idProject = value; }
        }

        public string NameProject
        {
            get { return nameProject; }
            set { nameProject = value; }
        }

        public string DescriptionProject
        {
            get { return descrptionProject; }
            set { descrptionProject = value; }
        }

        public int TypeProject
        {
            get { return typeProject; }
            set { typeProject = value; }
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        public int Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
