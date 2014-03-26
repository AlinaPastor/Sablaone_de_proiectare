using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class MedieSemestruDAL
    {
        DatabaseAccess db = new DatabaseAccess();
        public DataSet GetMedieSemByIDuri(int id_sem, int id_elev, int id_materie)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                 new SqlParameter("@semestruID", id_sem),
                 new SqlParameter("@elevID",id_elev),
                 new SqlParameter("@materieID",id_materie )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetMedieSemByIDuri", paramList);
        }

        internal void AddMedie(int id_elev, int id_materie, int id_sem, int media)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                
                new SqlParameter("@semestruID", id_sem),
                new SqlParameter("@elevID", id_elev),
                new SqlParameter("@materieID", id_materie),
                 new SqlParameter("@medie",media)

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddMedie", paramList);
        }
    }
}
