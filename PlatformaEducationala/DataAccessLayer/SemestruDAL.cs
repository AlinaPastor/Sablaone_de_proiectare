using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class SemestruDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataTable GetSemestre()
        {
            return db.ExecuteDataSet(DALHelper.Connection, "GetSemestre", null);
        }

        public DataTable GetSemestruById(int semID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@semID";
            param1.Value = semID;

            paramList[0] = param1;
           
            return db.ExecuteDataSet(DALHelper.Connection, "GetSemestreById", paramList);
        }

        internal void AsocAn_StudiuSemestru(int id_sem, int id_an)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@semID";
            param1.Value = id_sem;


            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@an_studiuID";
            param2.Value = id_an;

            paramList[0] = param1;
            paramList[1] = param2;
          
            db.ExecuteNonQuery(DALHelper.Connection, "AsocAn_StudiuSemestru", paramList);
            
        }

    }
}
