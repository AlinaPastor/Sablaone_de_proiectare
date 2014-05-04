using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class NotaDAL
    {

        DatabaseAccess db = new DatabaseAccess();

        public DataSet GetNoteByIDuri(int id_elev, int id_materie, int id_sem)
        {
            /*SqlParameter[] paramList = new SqlParameter[]
            {
                 new SqlParameter("@elevID",id_elev),
                 new SqlParameter("@materieID",id_materie),
                 new SqlParameter("@semestruID", id_sem)
                
                 
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetNoteByIDuri", paramList);*/
            return null;
        }

        public DataSet GetNoteByIDuri1(int id_elev, int id_materie, int id_sem)
        {
           /* SqlParameter[] paramList = new SqlParameter[]
            {
                 new SqlParameter("@elevID",id_elev),
                 new SqlParameter("@materieID",id_materie),
                 new SqlParameter("@semestruID", id_sem)
                
                 
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetNoteByIDuri1", paramList);*/
            return null;
        }

        public DataSet GetTezaByIDuri(int id_elev, int id_materie, int id_sem)
        {
            /* SqlParameter[] paramList = new SqlParameter[]
             {
                  new SqlParameter("@elevID",id_elev),
                  new SqlParameter("@materieID",id_materie),
                  new SqlParameter("@semestruID", id_sem)
                
                 
             };
             return db.ExecuteDataSet(DALHelper.Connection, "GetTezaByIDuri", paramList);*/
            return null;

        }

        internal void AddNota(int id_elev, int id_materie, int id_sem, int nota)
        {
           /* SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@elevID", id_elev),
                new SqlParameter("@materieID", id_materie),
                new SqlParameter("@semestruID", id_sem),
                new SqlParameter("@nota",nota)

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddNota", paramList); */
           
        }

        internal void DeleteNota(int id_nota)
        {
           /* SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@notaID", id_nota)
               

            };
            db.ExecuteNonQuery(DALHelper.Connection, "DeleteNota", paramList);*/
        }

        internal void AddTeza(int id_elev, int id_materie, int id_sem, int teza)
        {
           /* SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@elevID", id_elev),
                new SqlParameter("@materieID", id_materie),
                new SqlParameter("@semestruID", id_sem),
                new SqlParameter("@teza",teza)

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddTeza", paramList);*/
        }

    }
}
