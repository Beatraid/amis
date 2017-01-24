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
    class Faculty_REP:IDisposable, IRepository<Faculty>
    {

        OracleConnection connection;

        public Faculty_REP()
        {
            DataBase database = new DataBase();
            connection = database.Connect();
        }

        public bool CheckFacultyName(string name_fac, string name_vnz)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM FACULTY WHERE FACULTY_NAME = :faculty_name AND VNZ_NAME = :vnz_name",
                    Connection = this.connection,
                    Transaction = trans
                };

                command.Parameters.Add(new OracleParameter("faculty_name", name_fac));
                command.Parameters.Add(new OracleParameter("vnz_name", name_vnz));

                IDataReader reader = command.ExecuteReader();

                bool exist = false;

                if (reader.Read())
                {
                    exist = true;
                }

                trans.Commit();
                return exist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
                return false;
            }
        }

        public void Insert(Faculty en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Insert into Faculty 
                                    (FACULTY_NAME, VNZ_NAME) 
                                    Values(:faculty_name, :vnz_name)",
                    Connection = this.connection,
                    Transaction = tr
                };
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

        public void Update(Faculty en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Update FACULTY set 
                                    FACULTY_NAME = :faculty_name, VNZ_NAME = :vnz_name Where FACULTY_NAME = :faculty_name AND VNZ_NAME = :vnz_name" ,
                    Connection = this.connection,
                    Transaction = tr
                };
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

        public void Delete(Faculty en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Delete FROM Faculty 
                                   Where FACULTY_NAME = :faculty_name AND VNZ_NAME = :vnz_name",
                    Connection = this.connection,
                    Transaction = tr
                };
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

        public List<Faculty> ListOf()
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM FACULTY", this.connection);
                command.Transaction = trans;
                

                IDataReader reader = command.ExecuteReader();

                List<Faculty> ens = new List<Faculty>();

                while (reader.Read())
                {
                    Faculty en = PopulateEntity(reader);
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

        public List<Faculty> ListOf(string vnz_name)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM FACULTY where VNZ_NAME = :vnz_name", this.connection);
                command.Transaction = trans;

                command.Parameters.Add(new OracleParameter("vnz_nane", vnz_name));
                IDataReader reader = command.ExecuteReader();

                List<Faculty> ens = new List<Faculty>();

                while (reader.Read())
                {
                    Faculty en = PopulateEntity(reader);
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

        protected Faculty PopulateEntity(IDataReader reader)
        {
            Faculty en = new Faculty();
            en.Faculty_name = reader.GetString(reader.GetOrdinal("FACULTY_NAME"));
            en.Vnz_name = reader.GetString(reader.GetOrdinal("FACULTY_NAME"));
           
            return en;

        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
