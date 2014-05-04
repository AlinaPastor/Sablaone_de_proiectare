using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace PlatformaEducationala.DataAccessLayer
{
    static class DALHelper
    {
        private static readonly String connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        private static readonly DbProviderFactory factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["connectionString"].ProviderName);

        internal static IDbConnection Connection
        {
            get
            {
                IDbConnection con = factory.CreateConnection();
                con.ConnectionString = connectionString;

                return con;
            }
        }
    }
}
