using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
   public class LoginDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        internal DataTable LoginProfesor(string user, string parola)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramUser = DALHelper.ProviderFactory.CreateParameter();
            paramUser.ParameterName = "@user";
            paramUser.Value = user;

            DbParameter paramPass = DALHelper.ProviderFactory.CreateParameter();
            paramPass.ParameterName = "@parola";
            paramPass.Value = parola;


            paramList[0] = paramUser;
            paramList[1] = paramPass;
            return db.ExecuteDataSet(DALHelper.Connection, "LoginProfesor", paramList);
        }

        internal DataTable LoginDiriginte(string user, string parola)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)
            };
            return db.ExecuteDataSet(DALHelper.Connection, "LoginDiriginte", paramList);
        }

        internal DataTable LoginElev(string user, string parola)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)
            };
           return db.ExecuteDataSet(DALHelper.Connection, "LoginElev", paramList);
        }

        internal DataTable LoginAdmin(string user, string parola)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramUser = DALHelper.ProviderFactory.CreateParameter();
            paramUser.ParameterName = "@user";
            paramUser.Value = user;

            DbParameter paramPass = DALHelper.ProviderFactory.CreateParameter();
            paramPass.ParameterName = "@parola";
            paramPass.Value = parola;


            paramList[0] = paramUser;
            paramList[1] = paramPass;
            return db.ExecuteDataSet(DALHelper.Connection, "LoginAdmin", paramList);
        }

    }
}
