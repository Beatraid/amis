using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace BDKURSACH
{
    class Student_REP:IDisposable, IRepository<Student>
    {
        OracleConnection connection;

        public Student_REP()
        {
            DataBase database = new DataBase();
            connection = database.Connect();
        }

        public bool CheckStudentExist(string login)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM STUDENT WHERE STUDENT_LOGIN = :snudent_login",
                    Connection = this.connection,
                    Transaction = trans
                };
                command.Parameters.Add(new OracleParameter("snudent_login", login));

                IDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    trans.Commit();
                    return true;
                }
                trans.Commit();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return false;
            }
        }

        public bool CheckStudent(string login, string password)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM STUDENT WHERE STUDENT_LOGIN = :student_login",
                    Connection = this.connection,
                    Transaction = trans
                };

                command.Parameters.Add(new OracleParameter("student_login", login));
                IDataReader reader = command.ExecuteReader();

                string passCheck = String.Empty;
                bool exist = false;

                if (reader.Read())
                {
                    exist = true;
                    passCheck = reader.GetString(reader.GetOrdinal("STUDENT_PASSWORD"));

                }

                if (password != passCheck)
                {
                    trans.Commit();
                    return false;
                }
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return false;
            }
        }

        public void UpdateAvrg(string login, float avg)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Update Student set 
                                    AVERAGE = :average
                                    Where STUDENT_LOGIN = :student_login",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("average", avg));
                command.Parameters.Add(new OracleParameter("student_login", login));
                command.ExecuteNonQuery();
                tr.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tr.Rollback();
                return;
            }

        }

        public void Insert(Student en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Insert into Student 
                                    (STUDENT_LOGIN, STUDENT_PASSWORD, STUDENT_NAME, STUDENT_SURNAME, AVERAGE, GROUP_NAME, FACULTY_NAME, VNZ_NAME) 
                                    Values(:student_login, :student_password, :student_name, :student_surname, :average, :group_name, :faculty_name, :vnz_name)",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("student_login", en.Student_login));
                command.Parameters.Add(new OracleParameter("student_password", en.Student_password));
                command.Parameters.Add(new OracleParameter("student_name", en.Student_name));
                command.Parameters.Add(new OracleParameter("student_surname", en.Student_surname));
                command.Parameters.Add(new OracleParameter("average", en.Average));
                command.Parameters.Add(new OracleParameter("group_name", en.Group_name));
                command.Parameters.Add(new OracleParameter("faculty_name", en.Faculty_name));
                command.Parameters.Add(new OracleParameter("vnz_name", en.Vnz_name));
                command.ExecuteNonQuery();
                tr.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tr.Rollback();
                return;
            }
        }

        public void Update(Student en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Update Student set 
                                    STUDENT_LOGIN = :student_login, STUDENT_PASSWORD = :student_password, STUDENT_NAME = :student_name, STUDENT_SURNAME = :student_surname,
                                    AVERAGE = :average, GROUP_NAME = :group_name, FACULTY_NAME = :faculty_name, VNZ_NAME = :vnz_name
                                    Where STUDENT_LOGIN = :student_login",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("student_login", en.Student_login));
                command.Parameters.Add(new OracleParameter("student_password", en.Student_password));
                command.Parameters.Add(new OracleParameter("student_name", en.Student_name));
                command.Parameters.Add(new OracleParameter("student_surname", en.Student_surname));
                command.Parameters.Add(new OracleParameter("average", en.Average));
                command.Parameters.Add(new OracleParameter("group_name", en.Group_name));
                command.Parameters.Add(new OracleParameter("faculty_name", en.Faculty_name));
                command.Parameters.Add(new OracleParameter("vnz_name", en.Vnz_name));

                command.ExecuteNonQuery();
                tr.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tr.Rollback();
                return;
            }
        }

        public void Delete(Student en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Delete FROM Student 
                                   Where STUDENT_LOGIN = :student_login",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("student_login", en.Student_login));
                command.ExecuteNonQuery();
                tr.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tr.Rollback();
                return;
            }
        }

        public List<Student> ListOf()
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM STUDENT", this.connection);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();

                List<Student> ens = new List<Student>();

                while (reader.Read())
                {
                    Student en = PopulateEntity(reader);
                    ens.Add(en);
                }
                trans.Commit();
                return ens;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return null;
            }

        }


        public List<Student> ListOf(string vnzname, string facname, string grname)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM STUDENT WhERE VNZ_NAME = :vname AND FACULTY_NAME = :fname AND GROUP_NAME = :grname", this.connection);
                command.Parameters.Add("vname", vnzname);
                command.Parameters.Add("fname", facname);
                command.Parameters.Add("grname", grname);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();

                List<Student> ens = new List<Student>();

                while (reader.Read())
                {
                    Student en = PopulateEntity(reader);
                    ens.Add(en);
                }
                trans.Commit();
                return ens;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return null;
            }

        }
        public string GetLogin(string name, string surname)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM STUDENT WhERE STUDENT_NAME = :name AND STUDENT_SURNAME = :surname", this.connection);
                command.Parameters.Add("name", name);
                command.Parameters.Add("surname", surname);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    Student en = PopulateEntity(reader);
                    trans.Commit();
                    return en.Student_login;
                }
                trans.Commit();
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return "";
            }

        }

        public Student GetStudentByLogin(string login)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM STUDENT WhERE STUDENT_LOGIN = :log", this.connection);
                command.Parameters.Add("log", login);
                command.Transaction = trans;
                IDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    Student en = PopulateEntity(reader);
                    trans.Commit();
                    return en;
                }
                trans.Commit();
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return null;
            }

        }


        protected Student PopulateEntity(IDataReader reader)
        {
            Student en = new Student();
            en.Student_login = reader.GetString(reader.GetOrdinal("STUDENT_LOGIN"));
            en.Student_password = reader.GetString(reader.GetOrdinal("STUDENT_PASSWORD"));
            en.Student_name = reader.GetString(reader.GetOrdinal("STUDENT_NAME"));
            en.Student_surname = reader.GetString(reader.GetOrdinal("STUDENT_SURNAME"));
            en.Average = reader.GetFloat(reader.GetOrdinal("AVERAGE"));
            en.Group_name = reader.GetString(reader.GetOrdinal("GROUP_NAME"));
            en.Faculty_name = reader.GetString(reader.GetOrdinal("FACULTY_NAME"));
            en.Vnz_name = reader.GetString(reader.GetOrdinal("VNZ_NAME"));




            return en;

        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
