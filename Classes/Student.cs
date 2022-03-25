using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class Student : Person
    {
        private int idStudent;
        private int idGroup;

        public Student() : base()
        {
            idStudent = 0;
            idGroup = 0;
        }

        public Student(int _idStudent, string _login, string _password, string _firstName, string _secondName, string _fatherName, DateTime _dataOfBirthday, DateTime _dataOfRegistration, 
            string _email, int _gender,  int _idGroup) : 
            base(_login, _password, _firstName, _secondName, _fatherName, _dataOfBirthday, _dataOfRegistration, _email, _gender)
        {       
            idStudent = _idStudent;
            idGroup = _idGroup;
        }

        public Student(int _idStudent, Person person, int _idGroup) :
            base(person.Login, person.Password, person.FirstName, person.SecondName, person.FatherName, person.DataOfBirthday, person.DataOfRegistration, person.Email, person.Gender)
        {
            idStudent = _idStudent;
            idGroup = _idGroup;
        }

        public int IdStudent
        {
            get { return idStudent; }
            set { idStudent = value; }
        }
        public int IdGroup
        {
            get { return idGroup; }
            set { idGroup = value; }
        }
    }
}
