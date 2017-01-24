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
    class Teacher_REP:IDisposable, IRepository<Teacher>
    {
        OracleConnection connection;

        public Teacher_REP()
        {
            DataBase database = new DataBase();
            connection = database.Connect();
        }

        public bool CheckTeacherExist(string login)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM TEACHER WHERE TEACHER_LOGIN = :teacher_login",
                    Connection = this.connection,
                    Transaction = trans
                };
                command.Parameters.Add(new OracleParameter("teacher_login", login));

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


        public bool CheckTeacher(string login, string password)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM TEACHER WHERE TEACHER_LOGIN = :teacher_login",
                    Connection = this.connection,
                    Transaction = trans
                };

                command.Parameters.Add(new OracleParameter("teacher_login", login));
                IDataReader reader = command.ExecuteReader();

                string passCheck = String.Empty;
                bool exist = false;

                if (reader.Read())
                {
                    exist = true;
                    passCheck = reader.GetString(reader.GetOrdinal("TEACHER_PASSWORD"));

                }

                if (password != passCheck || !exist)
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

        public bool CheckAdmin(string login)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM TEACHER WHERE TEACHER_LOGIN = :teacher_login AND IS_ADMIN = 1",
                    Connection = this.connection,
                    Transaction = trans
                };

                command.Parameters.Add(new OracleParameter("teacher_login", login));

                IDataReader reader = command.ExecuteReader();

                string passCheck = String.Empty;
                bool exist = false;

                if (reader.Read())
                {
                    exist = true;
                    trans.Commit();
                }

                
                //trans.Commit();
                return exist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //trans.Rollback();
                return false;
            }
        }


        public void Insert(Teacher en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Insert into Teacher 
                                    (TEACHER_LOGIN, TEACHER_PASSWORD, TEACHER_NAME, TEACHER_SURNAME, IS_ADMIN) 
                                    Values(:teacher_login, :teacher_password, :teacher_name, :teacher_surname, :is_admin)",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("teacher_login", en.Teacher_login));
                command.Parameters.Add(new OracleParameter("teacher_password", en.Teacher_password));
                command.Parameters.Add(new OracleParameter("teacher_name", en.Teacher_name));
                command.Parameters.Add(new OracleParameter("teacher_surname", en.Teacher_surname));
                command.Parameters.Add(new OracleParameter("is_admin", en.Is_admin?1:0));
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

        public void Update(Teacher en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Update TEACHER set 
                                    TEACHER_LOGIN = :teacher_login, TEACHER_PASSWORD = :teacher_password, TEACHER_NAME = :teacher_name, TEACHER_SURNAME = :teacher_surname, IS_ADMIN = :is_admin
                                    Where TEACHER_LOGIN = :teacher_login",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("teacher_login", en.Teacher_login));
                command.Parameters.Add(new OracleParameter("teacher_password", en.Teacher_password));
                command.Parameters.Add(new OracleParameter("teacher_name", en.Teacher_name));
                command.Parameters.Add(new OracleParameter("teacher_surname", en.Teacher_surname));
                command.Parameters.Add(new OracleParameter("is_admin", en.Is_admin?1:0));
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

        public void Delete(Teacher en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Delete FROM TEACHER 
                                   Where TEACHER_LOGIN = :teacher_login",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("teacher_login", en.Teacher_login));
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

        public List<Teacher> ListOf()
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TEACHER", this.connection);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();

                List<Teacher> ens = new List<Teacher>();

                while (reader.Read())
                {
                    Teacher en = PopulateEntity(reader);
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

        public Teacher GetTeacherByLogin(string login)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TEACHER WhERE TEACHER_LOGIN = :log", this.connection);
                command.Parameters.Add("log", login);
                command.Transaction = trans;
                IDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    Teacher en = PopulateEntity(reader);
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

        protected Teacher PopulateEntity(IDataReader reader)
        {
            Teacher en = new Teacher();
            en.Teacher_login = reader.GetString(reader.GetOrdinal("TEACHER_LOGIN"));
            en.Teacher_password = reader.GetString(reader.GetOrdinal("TEACHER_PASSWORD"));
            en.Teacher_name = reader.GetString(reader.GetOrdinal("TEACHER_NAME"));
            en.Teacher_surname = reader.GetString(reader.GetOrdinal("TEACHER_SURNAME"));
            en.Is_admin = reader.GetInt32(reader.GetOrdinal("IS_ADMIN")) == 1;


            return en;

        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
