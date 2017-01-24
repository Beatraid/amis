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
    class Subject_REP : IDisposable, IRepository<Subject>
    {
         OracleConnection connection;

         public Subject_REP()
        {
            DataBase database = new DataBase();
            connection = database.Connect();
        }

        public void Insert(Subject en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Insert into SUBJECT 
                                    (SUBJECT_NAME, GROUP_NAME, TEACHER_LOGIN, FACULTY_NAME, VNZ_NAME) 
                                    Values(:subject_name, :group_name, :teacher_login, :f_name, :vnz_name)",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("subject_name", en.Subject_name));
                command.Parameters.Add(new OracleParameter("group_name", en.Group_name));
                command.Parameters.Add(new OracleParameter("teacher_login", en.Teacher_login));
                command.Parameters.Add(new OracleParameter("f_name", en.Faculty_name));
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

        //TODO
        public void Update(Subject en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Update SUBJECT set 
                                    SUBJECT_NAME = :subject_name, GROUP_NAME = :group_name, TEACHER_LOGIN = :teacher_login
                                    Where SUBJECT_NAME = :subject_name",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("subject_name", en.Subject_name));
                command.Parameters.Add(new OracleParameter("group_name", en.Group_name));
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

        public void Delete(Subject en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Delete FROM SUBJECT 
                                   Where SUBJECT_NAME = :subject_name AND Group_name = :grname AND faculty_name = :f_name AND vnz_name = :v_name",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("subject_name", en.Subject_name));
                command.Parameters.Add(new OracleParameter("grname", en.Group_name));
                command.Parameters.Add(new OracleParameter("f_name", en.Faculty_name));
                command.Parameters.Add(new OracleParameter("v_name", en.Vnz_name));
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

        public List<Subject> ListOf()
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM SUBJECT", this.connection);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();

                List<Subject> ens = new List<Subject>();

                while (reader.Read())
                {
                    Subject en = PopulateEntity(reader);
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

        public List<Subject> ListOf(string group_name, string faculty_name, string vnz_name)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM SUBJECT where GROUP_NAME = :group_name AND FACULTY_NAME = :faculty_name AND VNZ_NAME = :vnz_name", this.connection);
                command.Transaction = trans;

                command.Parameters.Add(new OracleParameter("group_name", group_name));
                command.Parameters.Add(new OracleParameter("faculty_name", faculty_name));
                command.Parameters.Add(new OracleParameter("vnz_name", vnz_name));

                IDataReader reader = command.ExecuteReader();

                List<Subject> ens = new List<Subject>();

                while (reader.Read())
                {
                    Subject en = PopulateEntity(reader);
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


        public List<Subject> ListOf(string teacher)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM SUBJECT WHERE TEACHER_LOGIN = :log", this.connection);
                command.Parameters.Add("log", teacher);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();

                List<Subject> ens = new List<Subject>();

                while (reader.Read())
                {
                    Subject en = PopulateEntity(reader);
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



        //public bool IsImportant(Subject s)
        //{
        //    OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
        //    try
        //    {
        //        OracleCommand command = new OracleCommand("SELECT * FROM SUBJECT WHERE SUBJECT_NAME = :subject_name AND Group_name = :grname AND faculty_name = :f_name AND vnz_name = :v_name AND TEACHER_LOGIN = :teacher_login", this.connection);
        //        command.Parameters.Add(new OracleParameter("subject_name", s.Subject_name));
        //        command.Parameters.Add(new OracleParameter("grname", s.Group_name));
        //        command.Parameters.Add(new OracleParameter("f_name", s.Faculty_name));
        //        command.Parameters.Add(new OracleParameter("v_name", s.Vnz_name));
        //        command.Parameters.Add(new OracleParameter("teacher_login", s.Teacher_login));

        //        command.Transaction = trans;


        //        IDataReader reader = command.ExecuteReader();


        //        if (reader.Read())
        //        {
        //            Subject en = PopulateEntity(reader);
        //            trans.Commit();
        //            return en.Type_subject;
        //        }
        //        trans.Commit();
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        trans.Rollback();
        //        return false;
        //    }


        //}

        public bool CheckSubjectExist(Subject s)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM SUBJECT WHERE  SUBJECT_NAME = :subject_name AND Group_name = :grname AND faculty_name = :f_name AND vnz_name = :v_name AND TEACHER_LOGIN = :teacher_logine",
                    Connection = this.connection,
                    Transaction = trans
                };
                command.Parameters.Add(new OracleParameter("subject_name", s.Subject_name));
                command.Parameters.Add(new OracleParameter("grname", s.Group_name));
                command.Parameters.Add(new OracleParameter("f_name", s.Faculty_name));
                command.Parameters.Add(new OracleParameter("v_name", s.Vnz_name));
                command.Parameters.Add(new OracleParameter("teacher_login", s.Teacher_login));

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


        protected Subject PopulateEntity(IDataReader reader)
        {
            Subject en = new Subject();
            en.Subject_name = reader.GetString(reader.GetOrdinal("SUBJECT_NAME"));
            en.Group_name = reader.GetString(reader.GetOrdinal("GROUP_NAME"));
            en.Teacher_login = reader.GetString(reader.GetOrdinal("TEACHER_LOGIN"));
            en.Vnz_name = reader.GetString(reader.GetOrdinal("VNZ_NAME"));
            en.Faculty_name = reader.GetString(reader.GetOrdinal("FACULTY_NAME"));
            return en;

        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
