using System;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;


namespace BDKURSACH
{
    class DataBase:IDisposable
    {
        OracleConnection connection;
        public DataBase()
        {
            try
            {
                connection = new OracleConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public static string CalcMD5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public void Dispose()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public OracleConnection Connect()
        {
            connection.Open();
            return connection;
        }

    }
}
