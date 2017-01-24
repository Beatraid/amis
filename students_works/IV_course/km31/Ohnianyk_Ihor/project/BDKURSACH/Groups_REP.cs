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
    class Groups_REP:IDisposable, IRepository<Groups>
    {

        OracleConnection connection;

        public Groups_REP()
        {
            DataBase database = new DataBase();
            connection = database.Connect();
        }

        public bool CheckGroupName(string name_gr, string name_fac, string name_vnz)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM GROUPS WHERE GROUP_NAME = :group_name AND FACULTY_NAME = :faculty_name AND VNZ_NAME = :vnz_name",
                    Connection = this.connection,
                    Transaction = trans
                };

                command.Parameters.Add(new OracleParameter("group_name", name_gr));
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

        public void Insert(Groups en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Insert into Groups 
                                    (GROUP_NAME, FACULTY_NAME, VNZ_NAME) 
                                    Values(:group_name, :faculty_name, :vnz_name)",
                    Connection = this.connection,
                    Transaction = tr
                };
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

        public void Update(Groups en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Update GROUPS set 
                                    FACULTY_NAME = :faculty_name, GROUP_NAME = :group_name, ",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("group_name", en.Group_name));
                command.Parameters.Add(new OracleParameter("faculty_name", en.Faculty_name));
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

        public void Delete(Groups en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Delete FROM GROUPS 
                                   Where GROUP_NAME = :group_name AND FACULTY_NAME = :faculty_name AND VNZ_NAME = :vnz_name" ,
                    Connection = this.connection,
                    Transaction = tr
                };
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

        public List<Groups> ListOf()
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM GROUPS", this.connection);
                command.Transaction = trans;


                IDataReader reader = command.ExecuteReader();

                List<Groups> ens = new List<Groups>();

                while (reader.Read())
                {
                    Groups en = PopulateEntity(reader);
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

        public List<Groups> ListOf(string faculty_name, string vnz_name)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM GROUPS where FACULTY_NAME = :faculty_name AND VNZ_NAME = :vnz_name", this.connection);
                command.Transaction = trans;

                command.Parameters.Add(new OracleParameter("faculty_name", faculty_name));
                command.Parameters.Add(new OracleParameter("vnz_name", vnz_name));

                IDataReader reader = command.ExecuteReader();

                List<Groups> ens = new List<Groups>();

                while (reader.Read())
                {
                    Groups en = PopulateEntity(reader);
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

        protected Groups PopulateEntity(IDataReader reader)
        {
            Groups en = new Groups();
            en.Group_name = reader.GetString(reader.GetOrdinal("GROUP_NAME"));
            en.Faculty_name = reader.GetString(reader.GetOrdinal("FACULTY_NAME"));
            en.Faculty_name = reader.GetString(reader.GetOrdinal("VNZ_NAME"));



            return en;

        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
