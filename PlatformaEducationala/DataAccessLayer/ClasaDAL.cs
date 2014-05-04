using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class ClasaDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataSet GetClase()
        {
            //return db.ExecuteDataSet(DALHelper.Connection, "GetClase", null);
            return null;
        }

        public DataSet GetClasaById(int clasaID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@clasaID",clasaID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetClasaById", paramList);
             */
            return null;
        }

        internal void AddClasa(string nume)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                
                new SqlParameter("@nume", nume)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddClasa", paramList);
             */
        }


        internal void UpdateClasa(int id_clasa, string nume)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@clasaID", id_clasa),
                new SqlParameter("@nume", nume)
                

            };
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateClasa", paramList);
             */
        }

        internal void DeleteClasa(int clasaID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@clasaID", clasaID)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "DeleteClasa", paramList);
             */
        }

        internal void AsocDiriginteClasa(int id_profrsor_dirig, int id_clasa)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID", id_profrsor_dirig),
                new SqlParameter("@clasaID", id_clasa)
               

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AsocDiriginteClasa", paramList);
             */
        }

        internal void AsocAn_StudiuClasa(int id_an_studiu, int id_clasa)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@an_studiuID", id_an_studiu),
                new SqlParameter("@clasaID", id_clasa)
               

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AsocAn_StudiuClasa", paramList);
             */
        }

        internal void AsocProfesorClasa(int id_profesor, int id_materie, int id_clasa, bool teza)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID", id_profesor),
                new SqlParameter("@materieID", id_materie),
                new SqlParameter("@clasaID", id_clasa),
                new SqlParameter("@teza", teza)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "AsocProfesorClasa", paramList);
             */
        }

        internal DataSet GetIdForProfMaterieClasaTeza(int id_profesor, int id_materie, int id_clasa, bool teza)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID", id_profesor),
                new SqlParameter("@materieID", id_materie),
                new SqlParameter("@clasaID", id_clasa),
                new SqlParameter("@teza", teza)
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GerIdForProfMaterieClasaTeza", paramList);
             */
            return null;
        }

        internal void UpdateAsocProfesorClasa(int id_prof_clasa, int id_profesor)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@prof_clasaID", id_prof_clasa),
                new SqlParameter("@profesorID", id_profesor)
               

            };
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateAsocProfesorClasa", paramList);
             */
        }


        public DataSet GetClasaByProfMatId(int profID, int matID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID",profID ),
                 new SqlParameter("@materieID",matID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetClasaByProfMatId", paramList);
             */
            return null;
        }

        public DataSet VerifTeza( int matID , int clasaID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                 new SqlParameter("@materieID",matID ),
                new SqlParameter("@clasaID",clasaID )
                
            };
            return db.ExecuteDataSet(DALHelper.Connection, "VerifTeza", paramList);
             */
            return null;
        }
    }
}
