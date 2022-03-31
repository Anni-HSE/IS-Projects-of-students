using IS_Projects_of_students.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
                    sql = $"INSERT INTO Teachers (Login, Password, FirstName, SecondName, FatherName, DateOfBirthday, DateOfRegistration, Email, Gender) " + values;
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
                        if (dataReader["Group"] != DBNull.Value)
                            student.IdGroup = Convert.ToInt32(dataReader["Group"]);
                        else
                            student.IdGroup = 0;
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
                        if(dataReader["Group"] != DBNull.Value)
                            student.IdGroup = Convert.ToInt32((int)dataReader["Group"]);
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

                command = new SqlCommand($"UPDATE Students SET Email = @email, Password = @password, Firstname = @firstName, SecondName = @secondName, FatherName = @fatherName, DataofBirthday = @dataOfBirthday," +
                    $" Gender = @gender, [Group] = @group WHERE IdStudent = {id}", connection);

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

                SqlParameter dob = new SqlParameter("@dataOfBirthday", System.Data.SqlDbType.DateTime);
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
                        if (dataReader["Group"] != DBNull.Value)
                            student.IdGroup = Convert.ToInt32(dataReader["Group"]);
                        else
                            student.IdGroup = 0;
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

        public static object[] GetSubjects()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> subjects = new List<string>();

                command = new SqlCommand($"SELECT NameSubject FROM Subjects", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        subjects.Add(dataReader["NameSubject"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return subjects.ToArray();
            }
        }

        public static int GetStudentId(string login)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT IdStudent FROM Students WHERE Login = '{login}'", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                       id = Convert.ToInt32(dataReader["IdStudent"]);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return id;
            }
        }

        public static List<StudentsProjects> GetStudentsProjects(int id)
        {
            List<StudentsProjects> projects = new List<StudentsProjects>();

            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT * FROM StudentProjects WHERE Student = {id}", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        StudentsProjects project = new StudentsProjects();
                        project.student = Convert.ToInt32(dataReader["Student"]);
                        project.project = Convert.ToInt32(dataReader["Project"]);
                        
                        if (dataReader["SolutionTask"] != DBNull.Value)
                            project.solutionTask = dataReader["SolutionTask"].ToString().Trim();
                        else
                            project.solutionTask = "";

                        if (dataReader["Note"] != DBNull.Value)
                            project.note = Convert.ToInt32(dataReader["Note"]);
                        else
                            project.note = 0;

                        if (dataReader["Commentary"] != DBNull.Value)
                            project.comment = dataReader["Commentary"].ToString().Trim();
                        else
                            project.comment = "";
                        projects.Add(project);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return projects;
        }

        public static List<Project> GetProjects(List<StudentsProjects> studentProjects)
        {
            List<Project> projects = new List<Project>();

            foreach (StudentsProjects item in studentProjects)
            {
                using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
                {
                    connection.Open();

                    command = new SqlCommand($"SELECT * FROM Projects WHERE IdProjects = {item.project}", connection);
                    try
                    {
                        SqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            Project project = new Project();
                            project.IdProject = Convert.ToInt32(dataReader["IdProjects"]);
                            project.Deadline = Convert.ToDateTime(dataReader["Deadline"]);
                            project.TypeProject = Convert.ToInt32(dataReader["TypeProject"]);
                            project.Subject = Convert.ToInt32(dataReader["Subject"]);
                            project.NameProject = dataReader["NameProject"].ToString().Trim();
                            project.DescriptionProject = dataReader["DesciptionProject"].ToString().Trim();
                            projects.Add(project);
                        }
                        dataReader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return projects;
        }

        public static object[] GetProjectTypes()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> projectTypes = new List<string>();

                command = new SqlCommand($"SELECT NameProjectType FROM ProjectTypes", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        projectTypes.Add(dataReader["NameProjectType"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return projectTypes.ToArray();
            }
        }

        public static int GetNote(int idProject, int idStudent)
        {
            int note = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT Note FROM StudentProjects WHERE Student = {idStudent} AND Project = {idProject}", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (dataReader["Note"] != DBNull.Value)
                            note = Convert.ToInt32(dataReader["Note"]);
                        else
                            note = 0;
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return note;
            }
        }
  
        public static string GetDescriptionProject(int idProject)
        {
            string description = "";
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT DesciptionProject FROM Projects WHERE IdProjects = {idProject}", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                            description = dataReader["DesciptionProject"].ToString().Trim();
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return description;
            }
        }

        public static int GetProjectId(string nameProject)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT IdProjects FROM Projects WHERE NameProject = '{nameProject}'", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader["IdProjects"]);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return id;
            }
        }

        public static string GetComment(int idProject, int idStudent)
        {
            string comment = "";
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT Commentary FROM StudentProjects WHERE Project = {idProject} AND Student = {idStudent}", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (dataReader["Commentary"] != DBNull.Value)
                            comment = dataReader["Commentary"].ToString().Trim();
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return comment;
            }
        }
    
        public static List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();

            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT * FROM Projects", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Project project = new Project();
                        project.IdProject = Convert.ToInt32(dataReader["IdProjects"]);
                        project.Deadline = Convert.ToDateTime(dataReader["Deadline"]);
                        project.TypeProject = Convert.ToInt32(dataReader["TypeProject"]);
                        project.Subject = Convert.ToInt32(dataReader["Subject"]);
                        project.NameProject = dataReader["NameProject"].ToString().Trim();
                        project.DescriptionProject = dataReader["DesciptionProject"].ToString().Trim();
                        projects.Add(project);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return projects;
        }

        public static object[] GetFacilitiesId()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> facilities = new List<string>();

                command = new SqlCommand($"SELECT Facility FROM Departments", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        facilities.Add(dataReader["Facility"].ToString().Trim());
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

        public static object[] GetDepartmentsId()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> departments = new List<string>();

                command = new SqlCommand($"SELECT Department FROM Subjects", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        departments.Add(dataReader["Department"].ToString().Trim());
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

        public static bool CheckNameProject(string nameProject)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT * FROM Projects WHERE NameProject = '{nameProject}'", connection);

                SqlDataReader dataReader = command.ExecuteReader();

                return dataReader.HasRows;
            }
        }

        public static int CreateProject(Project project)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                int number = -1;

                string sql;
                string values = $"values (@NameProject, @DesciptionProject, @Deadline, @Subject, @TypeProject)";

                sql = $"INSERT INTO Projects (NameProject, DesciptionProject, Deadline, Subject, TypeProject) " + values;


                command = connection.CreateCommand();
                command.CommandText = sql;

                SqlParameter NameProject = new SqlParameter("@NameProject", System.Data.SqlDbType.NVarChar);
                NameProject.Value = project.NameProject;
                command.Parameters.Add(NameProject);

                SqlParameter DescriptionProject = new SqlParameter("@DesciptionProject", System.Data.SqlDbType.NVarChar);
                DescriptionProject.Value = project.DescriptionProject;
                command.Parameters.Add(DescriptionProject);

                SqlParameter Deadline = new SqlParameter("@Deadline", System.Data.SqlDbType.DateTime);
                Deadline.Value = project.Deadline;
                command.Parameters.Add(Deadline);


                SqlParameter Subject = new SqlParameter("@Subject", System.Data.SqlDbType.Int);
                Subject.Value = project.Subject;
                command.Parameters.Add(Subject);

                SqlParameter TypeProject = new SqlParameter("@TypeProject", System.Data.SqlDbType.Int);
                TypeProject.Value = project.TypeProject;
                command.Parameters.Add(TypeProject);

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

        public static object[] GetProjectIds()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> ids = new List<string>();

                command = new SqlCommand($"SELECT IdProjects FROM Projects", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ids.Add(dataReader["IdProjects"].ToString().Trim());
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

        public static int UpdateProject(int id, Project project)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"UPDATE Projects SET NameProject = @NameProject, DesciptionProject = @DesciptionProject, Deadline = @Deadline, Subject = @Subject, TypeProject = @TypeProject" +
                    $" WHERE IdProjects = {id}", connection);

                SqlParameter NameProject = new SqlParameter("@NameProject", System.Data.SqlDbType.NVarChar);
                NameProject.Value = project.NameProject;
                command.Parameters.Add(NameProject);

                SqlParameter DescriptionProject = new SqlParameter("@DesciptionProject", System.Data.SqlDbType.NVarChar);
                DescriptionProject.Value = project.DescriptionProject;
                command.Parameters.Add(DescriptionProject);

                SqlParameter Deadline = new SqlParameter("@Deadline", System.Data.SqlDbType.DateTime);
                Deadline.Value = project.Deadline;
                command.Parameters.Add(Deadline);


                SqlParameter Subject = new SqlParameter("@Subject", System.Data.SqlDbType.Int);
                Subject.Value = project.Subject;
                command.Parameters.Add(Subject);

                SqlParameter TypeProject = new SqlParameter("@TypeProject", System.Data.SqlDbType.Int);
                TypeProject.Value = project.TypeProject;
                command.Parameters.Add(TypeProject);

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

        public static int RemoveProject(int id)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"DELETE FROM Projects WHERE IdProjects = {id}", connection);

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

        public static Project GetProject(int id)
        {
            Project project = new Project();
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                command = new SqlCommand($"SELECT * FROM Projects WHERE IdProjects = {id}", connection);

                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        project.IdProject = id;
                        project.NameProject = dataReader["NameProject"].ToString().Trim();
                        project.DescriptionProject = dataReader["DesciptionProject"].ToString().Trim();
                        project.Deadline = Convert.ToDateTime(dataReader["Deadline"]);
                        project.Subject = Convert.ToInt32(dataReader["Subject"]);
                        project.TypeProject = Convert.ToInt32(dataReader["TypeProject"]);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return project;
        }

        public static object[] GetstudentProjects(int id)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> ids = new List<string>();

                command = new SqlCommand($"SELECT Project FROM StudentProjects WHERE Student = {id}", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ids.Add(dataReader["Project"].ToString().Trim());
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

        public static int UpdateStudentProject(int idStudent, int idProject, int grade)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"UPDATE StudentProjects SET Grade = @Note WHERE Project = {idProject} AND Student = {idStudent}", connection);

                SqlParameter Grade = new SqlParameter("@Note", System.Data.SqlDbType.NVarChar);
                Grade.Value = grade;
                command.Parameters.Add(Grade);

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

        public static string GetSolutionTask(int idProject, int idStudent)
        {
            string solution ="";
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT SolutionTask FROM StudentProjects WHERE Student = {idStudent} AND Project = {idProject}", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (dataReader["SolutionTask"] != DBNull.Value)
                            solution = dataReader["SolutionTask"].ToString().Trim();
                        else
                            solution = "";
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return solution;
            }
        }

        public static DateTime GetDowlandDate(int idProject, int idStudent)
        {
            DateTime date = new DateTime();
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT DateofDowland FROM StudentProjects WHERE Student = {idStudent} AND Project = {idProject}", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (dataReader["DateofDowland"] != DBNull.Value)
                            date = Convert.ToDateTime(dataReader["DateofDowland"]);
                        else
                            date = new DateTime();
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return date;
            }
        }

        public static int UpdateSolutionTask(int idStudent, int idProject, string solution)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"UPDATE StudentProjects SET SolutionTask = @SolutionTask, DateofDowland = @DateofDowland WHERE Project = {idProject} AND Student = {idStudent}", connection);

                SqlParameter solutionTask = new SqlParameter("@SolutionTask", System.Data.SqlDbType.NVarChar);
                solutionTask.Value = solution;
                command.Parameters.Add(solutionTask);

                SqlParameter dateOfDowland = new SqlParameter("@DateofDowland", System.Data.SqlDbType.DateTime);
                dateOfDowland.Value = DateTime.Now;
                command.Parameters.Add(dateOfDowland);

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

        public static object[] GetstudentsFIO()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> fios = new List<string>();

                command = new SqlCommand($"SELECT FirstName, SecondName, FatherName FROM Students", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string fio = dataReader["SecondName"].ToString().Trim() + " " + dataReader["FirstName"].ToString().Trim() + " " + dataReader["FatherName"].ToString().Trim();
                        fios.Add(fio);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return fios.ToArray();
            }
        }

        public static object[] GetProjectNames()
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> names = new List<string>();

                command = new SqlCommand($"SELECT NameProject FROM Projects", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        names.Add(dataReader["NameProject"].ToString().Trim());
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return names.ToArray();
            }
        }

        public static int GetStudentIdUseFio(string fio)
        {
            string[] fioname = fio.Split(' ');
            int id = -1;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT IdStudent FROM Students WHERE SecondName = '{fioname[0]} AND FirstName = {fioname[1]} AND FAtherName = {fioname[2]}'", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader["IdStudent"]);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return id;
            }
        }

        public static int CheckStudentProject(int idStudent, int idProject)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                List<string> genders = new List<string>();

                command = new SqlCommand($"SELECT COUNT(*) FROM StudentProjects WHERE Student = {idStudent} AND Project = {idProject}", connection);
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

        public static int CreateStudentProject(int studentId, int projectId)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                int number = -1;

                string sql;
                string values = $"values (@studentId, @projectId)";

                sql = $"INSERT INTO StudentProjects (Student, Project) " + values;


                command = connection.CreateCommand();
                command.CommandText = sql;

                SqlParameter Student = new SqlParameter("@studentId", System.Data.SqlDbType.Int);
                Student.Value = studentId;
                command.Parameters.Add(Student);

                SqlParameter Project = new SqlParameter("@projectId", System.Data.SqlDbType.Int);
                Project.Value = projectId;
                command.Parameters.Add(Project);
              
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

        public static int UpdateGrade(int idStudent, int idProject, string commentary, int grade)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"UPDATE StudentProjects SET Note = @Note, Commentary = @Commentary WHERE Project = {idProject} AND Student = {idStudent}", connection);

                SqlParameter Note = new SqlParameter("@Note", System.Data.SqlDbType.Int);
                Note.Value = grade;
                command.Parameters.Add(Note);

                SqlParameter Commentary = new SqlParameter("@Commentary", System.Data.SqlDbType.NVarChar);
                Commentary.Value = commentary;
                command.Parameters.Add(Commentary);

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

        public static string GetstudentFIO(int idStudent)
        {
            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();
                string fio = "";

                command = new SqlCommand($"SELECT FirstName, SecondName, FatherName FROM Students WHERE IdStudent = {idStudent}", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        fio = dataReader["SecondName"].ToString().Trim() + " " + dataReader["FirstName"].ToString().Trim() + " " + dataReader["FatherName"].ToString().Trim();
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return fio;
            }
        }

        public static List<StudentsProjects> GetStudentsProjects()
        {
            List<StudentsProjects> projects = new List<StudentsProjects>();

            using (SqlConnection connection = new SqlConnection(QueriesForSQL.ConnecttionString))
            {
                connection.Open();

                command = new SqlCommand($"SELECT * FROM StudentProjects", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        StudentsProjects project = new StudentsProjects();
                        project.student = Convert.ToInt32(dataReader["Student"]);
                        project.project = Convert.ToInt32(dataReader["Project"]);

                        if (dataReader["SolutionTask"] != DBNull.Value)
                            project.solutionTask = dataReader["SolutionTask"].ToString().Trim();
                        else
                            project.solutionTask = "";

                        if (dataReader["Note"] != DBNull.Value)
                            project.note = Convert.ToInt32(dataReader["Note"]);
                        else
                            project.note = 0;

                        if (dataReader["Commentary"] != DBNull.Value)
                            project.comment = dataReader["Commentary"].ToString().Trim();
                        else
                            project.comment = "";
                        projects.Add(project);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return projects;
        }
    }
}
