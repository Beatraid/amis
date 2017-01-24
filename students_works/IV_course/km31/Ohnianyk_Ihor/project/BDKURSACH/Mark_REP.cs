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
    class Mark_REP
    {
         OracleConnection connection;

         public Mark_REP()
        {
            DataBase database = new DataBase();
            connection = database.Connect();
        }


        public int GetMarkStudent(string login, string subj)
         {
             OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
             try
             {
                 OracleCommand command = new OracleCommand("SELECT * FROM MARK WHERE STUDENT_LOGIN = :log AND SUBJECT_NAME = :sbname", this.connection);
                 command.Parameters.Add("log", login);
                 command.Parameters.Add("sbname", subj);
                 command.Transaction = trans;


                 IDataReader reader = command.ExecuteReader();

                 if (reader.Read())
                 {
                     Mark en = PopulateEntity(reader);
                     trans.Commit();
                     return en.Mark_value;
                 }
                 trans.Commit();
                 return 0;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 trans.Rollback();
                 return 0;
             }
         }


        public void Insert(Mark en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Insert into Mark 
                                    (MARK, STUDENT_LOGIN, SUBJECT_NAME) 
                                    Values(:mark, :student_login, :subject_name)",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("mark", en.Mark_value));
                command.Parameters.Add(new OracleParameter("student_login", en.Student_login));
                command.Parameters.Add(new OracleParameter("subject_name", en.Subject_name));
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

        public void Update(Mark en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Update MARK set 
                                    MARK = :mark, STUDENT_LOGIN = :student_login, SUBJECT_NAME = :subject_name
                                    Where MARK = :mark",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("mark", en.Mark_value));
                command.Parameters.Add(new OracleParameter("student_login", en.Student_login));
                command.Parameters.Add(new OracleParameter("subject_name", en.Subject_name));
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

        public void Delete(Mark en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Delete FROM MARK 
                                   Where MARK = :mark",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("mark", en.Mark_value));
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

        public List<Mark> ListOf()
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM MARK", this.connection);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();

                List<Mark> ens = new List<Mark>();

                while (reader.Read())
                {
                    Mark en = PopulateEntity(reader);
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

        public bool CheckExists(string log, string sub)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM MARK WHERE STUDENT_LOGIN = :log AND SUBJECT_NAME = :sub", this.connection);
                command.Parameters.Add("log", log);
                command.Parameters.Add("sub", sub);
                command.Transaction = trans;


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


        public List<Mark> ListOf(string login)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM MARK WHERE STUDENT_LOGIN = :log", this.connection);
                command.Parameters.Add("log", login);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();

                List<Mark> ens = new List<Mark>();

                while (reader.Read())
                {
                    Mark en = PopulateEntity(reader);
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

        public float AvMark(string login)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM MARK WHERE STUDENT_LOGIN = :log" , this.connection);
                command.Parameters.Add("log", login);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();
                int counter =0;
                float res =0;


                while (reader.Read())
                {
                    counter++;
                    Mark en = PopulateEntity(reader);
                    res += en.Mark_value;
                }
                trans.Commit();
                return res / counter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return 0;
            }

        }

        public double GetAverageMark(string login)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT AVERAGE(MARK)  FROM MARK WHERE STUDENT_LOGIN = :log", this.connection);
                command.Parameters.Add("log", login);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();
                int counter = 0;
                float res = 0;


                while (reader.Read())
                {
                    counter++;
                    Mark en = PopulateEntity(reader);
                    res += en.Mark_value;
                }
                trans.Commit();
                return res / counter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return 0;
            }

        }


        protected Mark PopulateEntity(IDataReader reader)
        {
            Mark en = new Mark();
            en.Mark_value = reader.GetInt32(reader.GetOrdinal("MARK"));
            en.Student_login = reader.GetString(reader.GetOrdinal("STUDENT_LOGIN"));
            en.Subject_name = reader.GetString(reader.GetOrdinal("SUBJECT_NAME"));

            return en;

        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
