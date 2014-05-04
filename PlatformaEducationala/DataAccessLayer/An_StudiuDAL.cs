using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class An_StudiuDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataTable GetAni_Studiu()
        {
            return db.ExecuteDataSet(DALHelper.Connection, "GetAni_Studiu", null);
        }

        public DataTable GetAn_StudiuById(int an_studiuID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramAnStudiu = DALHelper.ProviderFactory.CreateParameter();
            paramAnStudiu.ParameterName = "@an_studiuID";
            paramAnStudiu.Value = an_studiuID;

            paramList[0] = paramAnStudiu;

            return db.ExecuteDataSet(DALHelper.Connection, "GetAn_StudiuById", paramList);
        }

        internal void AddAn_Studiu(string an)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramAn = DALHelper.ProviderFactory.CreateParameter();
            paramAn.ParameterName = "@an";
            paramAn.Value = an;

            paramList[0] = paramAn;

            db.ExecuteNonQuery(DALHelper.Connection, "AddAn_Studiu", paramList);
            
        }


        internal void UpdateAn_Studiu(int id_an_studiu, string an)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramAnStudiuId = DALHelper.ProviderFactory.CreateParameter();
            paramAnStudiuId.ParameterName = "@an_studiuID";
            paramAnStudiuId.Value = id_an_studiu;

            DbParameter paramAn = DALHelper.ProviderFactory.CreateParameter();
            paramAn.ParameterName = "@an";
            paramAn.Value = an;

            paramList[0] = paramAnStudiuId;
            paramList[1] = paramAn;
     
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateAn_Studiu", paramList);
     
        }

        internal void DeleteAn_Studiu(int an_studiuID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramAnStudiuId = DALHelper.ProviderFactory.CreateParameter();
            paramAnStudiuId.ParameterName = "@an_studiuID";
            paramAnStudiuId.Value = an_studiuID;

            paramList[0] = paramAnStudiuId;

            db.ExecuteNonQuery(DALHelper.Connection, "DeleteAn_Studiu", paramList);
        }

    }
}
