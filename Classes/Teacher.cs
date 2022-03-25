using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class Teacher : Person
    {
        private int idTeacher;
        private string position;

        public Teacher() :
            base()
        {
            idTeacher = 0;
            position = null;
        }

        public Teacher(int _idTeacher, string _login, string _password, string _firstName, string _secondName, string _fatherName, DateTime _dataOfBirthday, DateTime _dataOfRegistration, string _email, int _gender, 
            string _position) :
            base(_login, _password, _firstName, _secondName, _fatherName, _dataOfBirthday, _dataOfRegistration, _email, _gender)
        {
            idTeacher = _idTeacher;
            position = _position;
        }

        public Teacher(int _idTeacher, Person person, string _position) :
            base(person.Login, person.Password, person.FirstName, person.SecondName, person.FatherName, person.DataOfBirthday, person.DataOfRegistration, person.Email, person.Gender)
        {
            idTeacher = _idTeacher;
            position = _position;
        }

        public int IdTeacher
        {
            get { return idTeacher; }
            set { idTeacher = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
