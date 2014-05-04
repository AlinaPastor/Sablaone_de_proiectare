using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class SemestruDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataSet GetSemestre()
        {
            //return db.ExecuteDataSet(DALHelper.Connection, "GetSemestre", null);
            return null;
        }

        public DataSet GetSemestruById(int semID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@semID",semID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetSemestreById", paramList);
             * */
            return null;
        }

        internal void AsocAn_StudiuSemestru(int id_sem, int id_an)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@semID", id_sem),
                new SqlParameter("@an_studiuID", id_an),
             
            };
            db.ExecuteNonQuery(DALHelper.Connection, "AsocAn_StudiuSemestru", paramList);
             * */
        }

    }
}
