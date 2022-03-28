﻿using IS_Projects_of_students.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Projects_of_students.Scripts
{
    public class QueriesForSQL
    {
        private static SqlCommand command;
        public static string ConnecttionString
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\IS Projects of students\Database1.mdf;Integrated Security=True";
            }
        }

        public static object[] GetGenders()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> genders = new List<string>();

                command = new SqlCommand($"SELECT NameGender FROM Genders", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        genders.Add(dataReader["NameGender"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return genders.ToArray();
            }
        }

        public static int CreateAccount(Person person, string typePerson)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                int number = -1;

                string sql;
                string values = $"values (@login, @password, @firstName, @secondName, @fatherName, @dateOfBirthday, @dateOfRegistration, @email, @gender)";

                if (typePerson == "Студент")
                {
                   sql = $"INSERT INTO Students (Login, Password, FirstName, SecondName, FatherName, DataOfBirthday, DataOfRegistration, Email, Gender) " + values;
                }
                else
                {
                    sql = $"INSERT INTO Teathers (Login, Password, FirstName, SecondName, FatherName, DataOfBirthday, DataOfRegistration, Email, Gender) " + values;
                }

                command = connection.CreateCommand();
                command.CommandText = sql;

                SqlParameter login = new SqlParameter("@login", System.Data.SqlDbType.NVarChar);
                login.Value = person.Login;
                command.Parameters.Add(login);

                SqlParameter password = new SqlParameter("@password", System.Data.SqlDbType.NVarChar);
                password.Value = person.Password;
                command.Parameters.Add(password);

                SqlParameter firstName = new SqlParameter("@firstName", System.Data.SqlDbType.NVarChar);
                firstName.Value = person.FirstName;
                command.Parameters.Add(firstName);

                SqlParameter secondName = new SqlParameter("@secondName", System.Data.SqlDbType.NVarChar);
                secondName.Value = person.SecondName;
                command.Parameters.Add(secondName);

                SqlParameter fatherName = new SqlParameter("@fatherName", System.Data.SqlDbType.NVarChar);
                fatherName.Value = person.FatherName;
                command.Parameters.Add(fatherName);

                SqlParameter dob = new SqlParameter("@dateOfBirthday", System.Data.SqlDbType.DateTime);
                dob.Value = person.DataOfBirthday;
                command.Parameters.Add(dob);

                SqlParameter dor = new SqlParameter("@dateOfRegistration", System.Data.SqlDbType.DateTime);
                dor.Value = person.DataOfRegistration;
                command.Parameters.Add(dor);

                SqlParameter email = new SqlParameter("@email", System.Data.SqlDbType.NVarChar);
                email.Value = person.Email;
                command.Parameters.Add(email);

                SqlParameter gender = new SqlParameter("@gender", System.Data.SqlDbType.Int);
                gender.Value = person.Gender;
                command.Parameters.Add(gender);

                try
                {
                    number = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return number;
            }
        }

        public static bool CheckLogin(string login, string typePerson)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                if (typePerson == "Студент")
                {
                    command = new SqlCommand($"SELECT Login FROM Students WHERE Login = '{login}'", connection);
                }
                else
                {
                    command = new SqlCommand($"SELECT Login FROM Teachers WHERE Login = '{login}'", connection);
                }

                SqlDataReader dataReader = command.ExecuteReader();
                
                return dataReader.HasRows;
            }
        }

        public static bool CheckLoginAndPassword(string login, string password, bool typePerson)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                if (typePerson)
                {
                    command = new SqlCommand($"SELECT Login, Password FROM Students WHERE Login = '{login.ToLower()}' AND Password = '{password}'", connection);
                }
                else
                {
                    command = new SqlCommand($"SELECT Login, Password FROM Teachers WHERE Login = '{login.ToLower()}' AND Password = '{password}'", connection);
                }

                SqlDataReader dataReader = command.ExecuteReader();

                return dataReader.HasRows;
            }
        }

        public static object[] GetGroups()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> groups = new List<string>();

                command = new SqlCommand($"SELECT NameGroup FROM Groups", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        groups.Add(dataReader["NameGroup"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return groups.ToArray();
            }
        }

        public static object[] GetPrograms()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> programs = new List<string>();

                command = new SqlCommand($"SELECT NameProgram FROM EducationalPrograms", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        programs.Add(dataReader["NameProgram"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return programs.ToArray();
            }
        }

        public static object[] GetFaculties()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> faculties = new List<string>();

                command = new SqlCommand($"SELECT NameFaculty FROM Faculties", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        faculties.Add(dataReader["NameFaculty"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return faculties.ToArray();
            }
        }

        public static object[] GetFacilities()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> facilities = new List<string>();

                command = new SqlCommand($"SELECT NameFacility FROM EducationalFacilities", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        facilities.Add(dataReader["NameFacility"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return facilities.ToArray();
            }
        }

        public static object[] GetDepartments()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> departments = new List<string>();

                command = new SqlCommand($"SELECT NameDepartment FROM Departments", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        departments.Add(dataReader["NameDepartment"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return departments.ToArray();
            }
        }

        public static Student GetStudent(string login)
        {
            Student student = new Student();
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();        
                command = new SqlCommand($"SELECT * FROM Students WHERE Login = '{login}'", connection);

                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        student.IdStudent = Convert.ToInt32(dataReader["IdStudent"]);
                        student.Login = login;
                        student.Password = dataReader["Password"].ToString().Trim();
                        student.FirstName = dataReader["FirstName"].ToString().Trim();
                        student.SecondName = dataReader["SecondName"].ToString().Trim();
                        student.FatherName = dataReader["FatherName"].ToString().Trim();
                        student.DataOfBirthday = Convert.ToDateTime(dataReader["DataOfBirthday"]);
                        student.DataOfRegistration = Convert.ToDateTime(dataReader["DataOfRegistration"]);
                        student.Email = dataReader["Email"].ToString().Trim();
                        student.Gender = Convert.ToInt32(dataReader["Gender"]);
                        student.IdGroup = Convert.ToInt32(dataReader["Group"]);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return student;
        }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                command = new SqlCommand($"SELECT * FROM Students", connection);

                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Student student = new Student();
                        student.IdStudent = Convert.ToInt32(dataReader["IdStudent"]);
                        student.Login = dataReader["Login"].ToString().Trim();
                        student.Password = dataReader["Password"].ToString().Trim();
                        student.FirstName = dataReader["FirstName"].ToString().Trim();
                        student.SecondName = dataReader["SecondName"].ToString().Trim();
                        student.FatherName = dataReader["FatherName"].ToString().Trim();
                        student.DataOfBirthday = Convert.ToDateTime(dataReader["DataOfBirthday"]);
                        student.DataOfRegistration = Convert.ToDateTime(dataReader["DataOfRegistration"]);
                        student.Email = dataReader["Email"].ToString().Trim();
                        student.Gender = Convert.ToInt32(dataReader["Gender"]);
                        if(dataReader["Group"] != null)
                            student.IdGroup = Convert.ToInt32(dataReader["Group"]);
                        else
                            student.IdGroup = 0;
                        students.Add(student);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return students;
        }

        public static int GetCountOfMaleStudent()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> genders = new List<string>();

                command = new SqlCommand($"SELECT COUNT(*) FROM Students WHERE Gender = 1", connection);
                try
                {
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }

            return count;
        }

        public static int GetCountOfFemaleStudent()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> genders = new List<string>();

                command = new SqlCommand($"SELECT COUNT(*) FROM Students WHERE Gender = 2", connection);
                try
                {
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return count;
        }

        public static int GetCountStudents()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> genders = new List<string>();

                command = new SqlCommand($"SELECT COUNT(*) FROM Students", connection);
                try
                {
                    count = (int) command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return count;
        }

        public static int CreateStudent(Student person)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                int number = -1;

                string sql;
                string values = $"values (@login, @password, @firstName, @secondName, @fatherName, @dateOfBirthday, @dateOfRegistration, @email, @gender, @group)";

                sql = $"INSERT INTO Students (Login, Password, FirstName, SecondName, FatherName, DataOfBirthday, DataOfRegistration, Email, Gender, [Group]) " + values;


                command = connection.CreateCommand();
                command.CommandText = sql;

                SqlParameter login = new SqlParameter("@login", System.Data.SqlDbType.NVarChar);
                login.Value = person.Login;
                command.Parameters.Add(login);

                SqlParameter password = new SqlParameter("@password", System.Data.SqlDbType.NVarChar);
                password.Value = person.Password;
                command.Parameters.Add(password);

                SqlParameter firstName = new SqlParameter("@firstName", System.Data.SqlDbType.NVarChar);
                firstName.Value = person.FirstName;
                command.Parameters.Add(firstName);

                SqlParameter secondName = new SqlParameter("@secondName", System.Data.SqlDbType.NVarChar);
                secondName.Value = person.SecondName;
                command.Parameters.Add(secondName);

                SqlParameter fatherName = new SqlParameter("@fatherName", System.Data.SqlDbType.NVarChar);
                fatherName.Value = person.FatherName;
                command.Parameters.Add(fatherName);

                SqlParameter dob = new SqlParameter("@dateOfBirthday", System.Data.SqlDbType.DateTime);
                dob.Value = person.DataOfBirthday;
                command.Parameters.Add(dob);

                SqlParameter dor = new SqlParameter("@dateOfRegistration", System.Data.SqlDbType.DateTime);
                dor.Value = person.DataOfRegistration;
                command.Parameters.Add(dor);

                SqlParameter email = new SqlParameter("@email", System.Data.SqlDbType.NVarChar);
                email.Value = person.Email;
                command.Parameters.Add(email);

                SqlParameter gender = new SqlParameter("@gender", System.Data.SqlDbType.Int);
                gender.Value = person.Gender;
                command.Parameters.Add(gender);

                SqlParameter group = new SqlParameter("@group", System.Data.SqlDbType.Int);
                group.Value = person.IdGroup;
                command.Parameters.Add(group);

                try
                {
                    number = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return number;
            }
        }

        public static object[] GetStudentIds()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> ids = new List<string>();

                command = new SqlCommand($"SELECT IdStudent FROM Students", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ids.Add(dataReader["IdStudent"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return ids.ToArray();
            }
        }

        public static int UpdateStudnent(int id, Student person)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> genders = new List<string>();

                command = new SqlCommand($"UPDATE Students SET Email = @email, Password = @password, Firstname = @firstName, SecondName = @secondName, FatherName = @fatherName, DataofBirthday = @dataOfBirthday, " +
                    $" Gender = @gender, Group = @group WHERE IdStudent = {id}", connection);

                SqlParameter password = new SqlParameter("@password", System.Data.SqlDbType.NVarChar);
                password.Value = person.Password;
                command.Parameters.Add(password);

                SqlParameter firstName = new SqlParameter("@firstName", System.Data.SqlDbType.NVarChar);
                firstName.Value = person.FirstName;
                command.Parameters.Add(firstName);

                SqlParameter secondName = new SqlParameter("@secondName", System.Data.SqlDbType.NVarChar);
                secondName.Value = person.SecondName;
                command.Parameters.Add(secondName);

                SqlParameter fatherName = new SqlParameter("@fatherName", System.Data.SqlDbType.NVarChar);
                fatherName.Value = person.FatherName;
                command.Parameters.Add(fatherName);

                SqlParameter dob = new SqlParameter("@dateOfBirthday", System.Data.SqlDbType.DateTime);
                dob.Value = person.DataOfBirthday;
                command.Parameters.Add(dob);

                SqlParameter email = new SqlParameter("@email", System.Data.SqlDbType.NVarChar);
                email.Value = person.Email;
                command.Parameters.Add(email);

                SqlParameter gender = new SqlParameter("@gender", System.Data.SqlDbType.Int);
                gender.Value = person.Gender;
                command.Parameters.Add(gender);

                SqlParameter group = new SqlParameter("@group", System.Data.SqlDbType.Int);
                group.Value = person.IdGroup;
                command.Parameters.Add(group);

                try
                {
                    count = (int)command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return count;
        }

        public static int RemoveStudent(int id)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> genders = new List<string>();

                command = new SqlCommand($"DELETE FROM Students WHERE IDStudent = {id}", connection);
        
                try
                {
                    count = (int)command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return count;
        }

        public static Student GetStudent(int id)
        {
            Student student = new Student();
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                command = new SqlCommand($"SELECT * FROM Students WHERE IdStudent = {id}", connection);

                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        student.IdStudent = Convert.ToInt32(dataReader["IdStudent"]);
                        student.Login = dataReader["Login"].ToString().Trim();
                        student.Password = dataReader["Password"].ToString().Trim();
                        student.FirstName = dataReader["FirstName"].ToString().Trim();
                        student.SecondName = dataReader["SecondName"].ToString().Trim();
                        student.FatherName = dataReader["FatherName"].ToString().Trim();
                        student.DataOfBirthday = Convert.ToDateTime(dataReader["DataOfBirthday"]);
                        student.DataOfRegistration = Convert.ToDateTime(dataReader["DataOfRegistration"]);
                        student.Email = dataReader["Email"].ToString().Trim();
                        student.Gender = Convert.ToInt32(dataReader["Gender"]);
                        student.IdGroup = Convert.ToInt32(dataReader["Group"]);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return student;
        }
    }
}
