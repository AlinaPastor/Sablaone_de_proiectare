using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PlatformaEducationala.DataAccessLayer
{
    class ElevDAL
    {

        DatabaseAccess db = new DatabaseAccess();

        public DataSet GetElevi()
        {
            //return db.ExecuteDataSet(DALHelper.Connection, "GetElevi", null);
            return null;
        }

        public DataSet GetEleviFaraClasa()
        {
           // return db.ExecuteDataSet(DALHelper.Connection, "GetEleviFaraClasa1", null);
            return null;
        }


        public DataSet GetEleviById(int elevID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@elevID",elevID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetEleviById", paramList);
             */
            return null;
        }

        internal void AddElev(string nume, string prenume, string user, string parola)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                
                new SqlParameter("@nume", nume),
                new SqlParameter("@prenume", prenume),
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AddElev", paramList);
             */
        }


        internal void UpdateElev(int id_elev, string nume, string prenume, string user, string parola)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@elevID", id_elev),
                new SqlParameter("@nume", nume),
                new SqlParameter("@prenume", prenume),
                new SqlParameter("@user", user),
                new SqlParameter("@parola", parola)

            };
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateElev", paramList);
             */
        }

        internal void DeleteElev(int elevID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@elevID", elevID)
            };
            db.ExecuteNonQuery(DALHelper.Connection, "DeleteElev", paramList);
             */
        }

        internal void AsocElevClasa(int id_elev,int id_clasa)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@elevID", id_elev),
                new SqlParameter("@clasaID", id_clasa)
               

            };
            db.ExecuteNonQuery(DALHelper.Connection, "AsocElevClasa", paramList);
             */
        }

        public DataSet GetEleviByClasaId(int clasaID)
        {
            /*
            SqlParameter[] paramList = new SqlParameter[]
            {
                new SqlParameter("@clasaID",clasaID )
            };
            return db.ExecuteDataSet(DALHelper.Connection, "GetEleviByClasaId", paramList);
             */
            return null;
        }

    }
}
