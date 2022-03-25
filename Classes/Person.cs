using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Projects_of_students.Classes
{
    public class Person
    {
        private string login;
        private string password;

        private string firstName;
        private string secondName;
        private string fatherName;

        private DateTime dataOfBirthday;
        private DateTime dataOfRegistration;

        private string email;
        private int gender;

        public Person()
        {
            login = null;
            password = null;
            firstName = null;
            secondName = null;
            fatherName = null;
            dataOfBirthday = new DateTime();
            dataOfRegistration = new DateTime();
            email = null;
        }

        public Person(string _login, string _password, string _firstName, string _secondName,  string _fatherName, DateTime _dataOfBirthday, DateTime _dataOfRegistration, string _email, int _gender)
        {
            login = _login;
            password = _password;
            firstName = _firstName;
            secondName = _secondName;
            fatherName = _fatherName;
            dataOfBirthday = _dataOfBirthday;
            dataOfRegistration = _dataOfRegistration;
            email = _email;
            gender = _gender;
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }
        public DateTime DataOfBirthday
        {
            get { return dataOfBirthday; }
            set { dataOfBirthday = value; }
        }
        public DateTime DataOfRegistration
        {
            get { return dataOfRegistration; }
            set { dataOfRegistration = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}
