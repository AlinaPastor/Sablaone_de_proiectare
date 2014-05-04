using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class ElevDAL
    {

        DatabaseAccess db = new DatabaseAccess();

        public DataTable GetElevi()
        {
            return db.ExecuteDataSet(DALHelper.Connection, "GetElevi", null);
        }

        public DataTable GetEleviFaraClasa()
        {
            return db.ExecuteDataSet(DALHelper.Connection, "GetEleviFaraClasa1", null);
        }


        public DataTable GetEleviById(int elevID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramElev = DALHelper.ProviderFactory.CreateParameter();
            paramElev.ParameterName = "@elevID";
            paramElev.Value = elevID;

            paramList[0] = paramElev;

            return db.ExecuteDataSet(DALHelper.Connection, "GetEleviById", paramList);
             
        }

        internal void AddElev(string nume, string prenume, string user, string parola)
        {
            DbParameter[] paramList = new DbParameter[4];
            
            DbParameter paramNume = DALHelper.ProviderFactory.CreateParameter();
            paramNume.ParameterName = "@nume";
            paramNume.Value = nume;

            DbParameter paramPrenume = DALHelper.ProviderFactory.CreateParameter();
            paramPrenume.ParameterName = "@prenume";
            paramPrenume.Value = prenume;

            DbParameter paramUser = DALHelper.ProviderFactory.CreateParameter();
            paramUser.ParameterName = "@user";
            paramUser.Value = user;

            DbParameter paramParola = DALHelper.ProviderFactory.CreateParameter();
            paramParola.ParameterName = "@parola";
            paramParola.Value = parola;

            paramList[0] = paramNume;
            paramList[1] = paramPrenume;
            paramList[2] = paramUser;
            paramList[3] = paramParola;

            db.ExecuteNonQuery(DALHelper.Connection, "AddElev", paramList);
             
        }


        internal void UpdateElev(int elevID, string nume, string prenume, string user, string parola)
        {
            DbParameter[] paramList = new DbParameter[5];
            
            DbParameter paramIdElev = DALHelper.ProviderFactory.CreateParameter();
            paramIdElev.ParameterName = "@elevID";
            paramIdElev.Value = elevID;

            DbParameter paramNume = DALHelper.ProviderFactory.CreateParameter();
            paramNume.ParameterName = "@nume";
            paramNume.Value = nume;

            DbParameter paramPrenume = DALHelper.ProviderFactory.CreateParameter();
            paramPrenume.ParameterName = "@prenume";
            paramPrenume.Value = prenume;

            DbParameter paramUser = DALHelper.ProviderFactory.CreateParameter();
            paramUser.ParameterName = "@user";
            paramUser.Value = user;

            DbParameter paramParola = DALHelper.ProviderFactory.CreateParameter();
            paramParola.ParameterName = "@parola";
            paramParola.Value = parola;

            paramList[0] = paramIdElev;
            paramList[1] = paramNume;
            paramList[2] = paramPrenume;
            paramList[3] = paramUser;
            paramList[4] = paramParola;

            db.ExecuteNonQuery(DALHelper.Connection, "UpdateElev", paramList);
        }

        internal void DeleteElev(int elevID)
        {

            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramIdElev = DALHelper.ProviderFactory.CreateParameter();
            paramIdElev.ParameterName = "@elevID";
            paramIdElev.Value = elevID;

            paramList[0] = paramIdElev;

            db.ExecuteNonQuery(DALHelper.Connection, "DeleteElev", paramList);
            
        }

        internal void AsocElevClasa(int elevID,int clasaID)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramIdElev = DALHelper.ProviderFactory.CreateParameter();
            paramIdElev.ParameterName = "@elevID";
            paramIdElev.Value = elevID;

            DbParameter paramIdClasa = DALHelper.ProviderFactory.CreateParameter();
            paramIdClasa.ParameterName = "@clasaID";
            paramIdClasa.Value = clasaID;

            paramList[0] = paramIdElev;
            paramList[1] = paramIdClasa;

            db.ExecuteNonQuery(DALHelper.Connection, "AsocElevClasa", paramList);

        }

        public DataTable GetEleviByClasaId(int clasaID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramIdClasa = DALHelper.ProviderFactory.CreateParameter();
            paramIdClasa.ParameterName = "@clasaID";
            paramIdClasa.Value = clasaID;

            paramList[0] = paramIdClasa;
            
            return db.ExecuteDataSet(DALHelper.Connection, "GetEleviByClasaId", paramList);
            
        }

    }
}
