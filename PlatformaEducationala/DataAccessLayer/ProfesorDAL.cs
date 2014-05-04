using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class ProfesorDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataSet GetProfesori()
        {
            return null;//return db.ExecuteDataSet(DALHelper.Connection, "GetProfesori", null);
        }

        public DataSet GetProfesoriById(int profesorID)
        {
            /*SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID",profesorID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetProfesoriById", paramList);*/
            return null;
        }

        public DataSet GetProfesoriByMaterieId(int materieID)
        {
           /* SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@materieID",materieID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetProfesoriByMaterieId", paramList);*/
            return null;
        }
        internal void AddProfesor(string nume, string prenume, string user, string parola)
        {
          /*  SqlParameter[] paramList = new SqlParameter[]
            {
                
                new SqlParameter("@nume", nume),
                new SqlParameter("@prenume", prenume),
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddProfesor", paramList);*/
        }


        internal void UpdateProfesor(int id_profesor, string nume, string prenume, string user, string parola)
        {
         /*   SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID", id_profesor),
                new SqlParameter("@nume", nume),
                new SqlParameter("@prenume", prenume),
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)

            };
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateProfesor", paramList);*/
        }

        internal void DeleteProfesor(int profesorID)
        {
           /* SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID", profesorID)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "DeleteProfesor", paramList);*/
        }

        internal void AsocProfesorMaterie(int id_profesor, int id_materie)
        {
           /* SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@profesorID", id_profesor),
                new SqlParameter("@materieID", id_materie)
               

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AsocProfesorMaterie", paramList);*/
        }

        public DataSet GetIdForProfMaterie( int id_materie, int id_profesor)
        {
         /*   SqlParameter[] paramList = new SqlParameter[]
            {
                 new SqlParameter("@materieID", id_materie),
                new SqlParameter("@profesorID", id_profesor)
               
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GerIdForProfMaterie", paramList);*/
            return null;
        }


        internal void UpdateAsocProfesorMaterie(int id_prof_materie,  int id_profesor)
        {
            /*SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@prof_materieID", id_prof_materie),
               // new SqlParameter("@materieID", id_materie),
                new SqlParameter("@profesorID", id_profesor)
               

            };
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateAscoProfesorMaterie", paramList);*/
        }
    }
}
