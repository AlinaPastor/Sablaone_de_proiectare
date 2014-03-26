using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PlatformaEducationala.DataAccessLayer
{
   public class LoginDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        internal DataSet LoginProfesor(string user, string parola)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)
            };
           return db.ExecuteDataSet(DALHelper.Connection, "LoginProfesor", paramList);
        }

        internal DataSet LoginDiriginte(string user, string parola)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)
            };
            return db.ExecuteDataSet(DALHelper.Connection, "LoginDiriginte", paramList);
        }

        internal DataSet LoginElev(string user, string parola)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)
            };
           return db.ExecuteDataSet(DALHelper.Connection, "LoginElev", paramList);
        }

        internal DataSet LoginAdmin(string user, string parola)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)
            };
            return db.ExecuteDataSet(DALHelper.Connection, "LoginAdmin", paramList);
        }

    }
}
