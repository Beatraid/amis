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
    class VNZ_REP:IDisposable, IRepository<VNZ>
    {
        OracleConnection connection;

        public VNZ_REP()
        {
            DataBase database = new DataBase();
            connection = database.Connect();
        }

        public bool CheckVNZName(string name)
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                OracleCommand command = new OracleCommand
                {
                    CommandText = @"SELECT * FROM VNZ WHERE VNZ_NAME = :vnz_name",
                    Connection = this.connection,
                    Transaction = trans
                };

                command.Parameters.Add(new OracleParameter("vnz_name", name));
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

        public void Insert(VNZ en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Insert into VNZ 
                                    (VNZ_NAME) 
                                    Values(:name)",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("name", en.Vnz_name));
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

        public void Update(VNZ en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Update VNZ set 
                                    VNZ_NAME = :name Where VNZ_NAME = :name" ,
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("name", en.Vnz_name));
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

        public void Delete(VNZ en)
        {
            OracleTransaction tr = connection.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                OracleCommand command = new OracleCommand()
                {
                    CommandText = @"Delete FROM VNZ 
                                    Where VNZ_NAME = :name",
                    Connection = this.connection,
                    Transaction = tr
                };
                command.Parameters.Add(new OracleParameter("name", en.Vnz_name));
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

        public List<VNZ> ListOf()
        {
            OracleTransaction trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM VNZ", this.connection);
                command.Transaction = trans;
                

                IDataReader reader = command.ExecuteReader();

                List<VNZ> ens = new List<VNZ>();

                while (reader.Read())
                {
                    VNZ en = PopulateEntity(reader);
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

        protected VNZ PopulateEntity(IDataReader reader)
        {
            VNZ en = new VNZ();
            en.Vnz_name = reader.GetString(reader.GetOrdinal("VNZ_NAME"));
           
            return en;

        }

        public void Dispose()
        {
            connection.Close();
        }

    }
}
