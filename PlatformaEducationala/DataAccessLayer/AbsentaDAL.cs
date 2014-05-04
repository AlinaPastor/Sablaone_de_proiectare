using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class AbsentaDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataSet GetAbsenteByIDuri(int id_sem, int id_elev, int id_materie)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                 new SqlParameter("@semestruID", id_sem),
                 new SqlParameter("@elevID",id_elev),
                 new SqlParameter("@materieID",id_materie )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteByIDuri", paramList);
             */
            return null;
        }

        public DataSet GetAbsenteByIDElev(int id_elev)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                
                 new SqlParameter("@elevID",id_elev)
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteByIDElev", paramList);
             */
            return null;
        }

        public DataSet GetAbsenteNemotivateByIDElev(int id_elev)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                
                 new SqlParameter("@elevID",id_elev)
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteNemotivateByIDElev", paramList);
             */
            return null;
        }

        public DataSet GetAbsenteClasa(int id_clasa)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
          
                 new SqlParameter("@clasaID",id_clasa )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteClasa", paramList);
             */
            return null;
        }

        public DataSet GetAbsenteClasaNemotivate(int id_clasa)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
          
                 new SqlParameter("@clasaID",id_clasa )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteClasaNemotivate", paramList);
             */
            return null;
        } 
        internal void AddAbsenta(int id_sem, int id_elev, int id_materie, bool motivata, bool motivabila)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                
                new SqlParameter("@semestruID", id_sem),
                new SqlParameter("@elevID", id_elev),
                new SqlParameter("@materieID", id_materie),
                new SqlParameter("@motivata",motivata),
                new SqlParameter("@motivabila",motivabila)

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddAbsenta", paramList);
             */
        }

        internal void MotivareAbsenta(int id_absenta)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@absentaID", id_absenta)
               

            };
            db.ExecuteNonQuery(DALHelper.Connection, "MotivareAbsenta", paramList);
             */
        }

        public DataSet GetMotivabilitateById(int id_absenta)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                 new SqlParameter("@absentaID", id_absenta)
                
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetMotivabilitateById", paramList);
             */
            return null;
        }

    }

}
