using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class MaterieDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataSet GetMaterii()
        {
            return db.ExecuteDataSet(DALHelper.Connection, "GetMaterii", null);
        }

        public DataSet GetMaterieById(int materieID)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@materieID",materieID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetMaterieById", paramList);
        }

        internal void AddMaterie(string nume)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                
                new SqlParameter("@nume", nume)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddMaterie", paramList);
        }


        internal void UpdateMaterie(int id_materie, string nume)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@materieID", id_materie),
                new SqlParameter("@nume", nume)
                

            };
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateMaterie", paramList);
        }

        internal void DeleteMaterie(int materieID)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@materieID", materieID)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "DeleteMaterie", paramList);
        }

        public DataSet GetMaterieByProfId(int profID)
        {
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID",profID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetMaterieByProfId", paramList);
        }
    }
}
