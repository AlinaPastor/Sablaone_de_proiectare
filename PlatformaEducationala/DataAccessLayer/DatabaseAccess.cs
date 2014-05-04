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
        public void ExecuteNonQuery(SqlConnection conn, String storedProcedureName, SqlParameter[] paramsList)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(storedProcedureName, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (paramsList != null)
                {
                    foreach (SqlParameter param in paramsList)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public DataSet ExecuteDataSet(SqlConnection conn, String storedProcedureName, DbParameter[] paramsList)
        {
            // noi
            DataSet dataSet = new DataSet();
            using (IDbConnection con = DALHelper.Connection) 
            {
                using (IDbCommand command = con.CreateCommand()) 
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;
                    con.Open();

                    if (paramsList != null)
                    {
                        foreach (DbParameter param in paramsList)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    dataSet.Load(command.ExecuteReader());
                }
            }
            return dataSet;
          
            
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

        public void GetProviderFactoryClasses()
        {

            IDbConnection con = DALHelper.Connection;

            using (IDbCommand command = con.CreateCommand())
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "GetElevi";
                con.Open();


                using (IDataReader reader = command.ExecuteReader())
                {
                   

                    while (reader.Read())
                    {
                        MessageBox.Show(reader["user_elev"].ToString());
                    }
                }
            }




            /*
            
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
 
            using (DbConnection con = factory.CreateConnection())
            {
                con.ConnectionString = "Data Source=Alex-PC;Initial Catalog=PlatformaEduDB;User Id=sa;Password=1;";

                using (DbCommand com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "SELECT user_admin FROM admin";

                    con.Open();

                    //com.ExecuteNonQuery();
                    //string result = com.Parameters["ReturnValue"].ToString();



                    using (IDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader["user_admin"].ToString());
                        }
                    }
                    

                    con.Close();
                }
            }*/
        }

    }
}
