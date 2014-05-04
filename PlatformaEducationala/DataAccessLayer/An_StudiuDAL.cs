using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class An_StudiuDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataSet GetAni_Studiu()
        {
            /*
            return db.ExecuteDataSet(DALHelper.Connection, "GetAni_Studiu", null);
             */
            return null;
        }

        public DataSet GetAn_StudiuById(int an_studiuID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@an_studiuID",an_studiuID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetAn_StudiuById", paramList);
             */
            return null;
        }

        internal void AddAn_Studiu(string an)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                
                new SqlParameter("@an", an)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddAn_Studiu", paramList);
             */
        }


        internal void UpdateAn_Studiu(int id_an_studiu, string an)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@an_studiuID", id_an_studiu),
                new SqlParameter("@an", an)
                

            };
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateAn_Studiu", paramList);
             */
        }

        internal void DeleteAn_Studiu(int an_studiuID)
        {
            /*SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@an_studiuID", an_studiuID)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "DeleteAn_Studiu", paramList);
             */
        }

       

    }
}
