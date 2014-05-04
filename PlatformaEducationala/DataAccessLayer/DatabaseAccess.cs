using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class DatabaseAccess
    {
        public void ExecuteNonQuery(IDbConnection conn, String storedProcedureName, DbParameter[] paramsList)
        {
            using (IDbCommand command = conn.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = storedProcedureName;
                conn.Open();

                if (paramsList != null)
                {
                    foreach (SqlParameter param in paramsList)
                    {
                        command.Parameters.Add(param);
                    }
                }

                // se executa procedura
                IDataReader reader = command.ExecuteReader();
            }
        }
        public DataTable ExecuteDataSet(IDbConnection conn, String storedProcedureName, DbParameter[] paramsList)
        {
            // noi
            DataTable dataTable = new DataTable();
            using (conn)
            {
                using (IDbCommand command = conn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;
                    conn.Open();

                    if (paramsList != null)
                    {
                        foreach (DbParameter param in paramsList)
                        {
                            command.Parameters.Add(param);

                        }
                    }
                    // se executa procedura
                    IDataReader reader = command.ExecuteReader();

                    // se initializeaza datatable
                    dataTable.Load(reader);
                }
            }
            return dataTable;


            // end noi
            /*

            DataSet result = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand(storedProcedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (paramsList != null)
                {
                    foreach (SqlParameter param in paramsList)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
                adapter.Dispose();
            }
            finally
            {
                conn.Close();
            }
            return result;
            */
        }

        DbConnection GetConnection(string connStr)
        {
            MessageBox.Show(connStr);
            string providerName = null;
            var csb = new DbConnectionStringBuilder { ConnectionString = connStr };

            if (csb.ContainsKey("provider"))
            {
                providerName = csb["provider"].ToString();
            }
            else
            {
                var css = ConfigurationManager
                                  .ConnectionStrings
                                  .Cast<ConnectionStringSettings>()
                                  .FirstOrDefault(x => x.ConnectionString == connStr);
                if (css != null) providerName = css.ProviderName;
            }

            if (providerName != null)
            {
                var providerExists = DbProviderFactories
                                            .GetFactoryClasses()
                                            .Rows.Cast<DataRow>()
                                            .Any(r => r[2].Equals(providerName));
                if (providerExists)
                {
                    var factory = DbProviderFactories.GetFactory(providerName);
                    var dbConnection = factory.CreateConnection();

                    dbConnection.ConnectionString = connStr;
                    return dbConnection;
                }
            }

            return null;
        }

    }
}
