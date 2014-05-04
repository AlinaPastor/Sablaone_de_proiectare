using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class MaterieDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataTable GetMaterii()
        {
            return db.ExecuteDataSet(DALHelper.Connection, "GetMaterii", null);
        }

        public DataTable GetMaterieById(int materieID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramIdMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramIdMaterie.ParameterName = "@materieID";
            paramIdMaterie.Value = materieID;


            paramList[0] = paramIdMaterie;

            return db.ExecuteDataSet(DALHelper.Connection, "GetMaterieById", paramList);
            
        }

        internal void AddMaterie(string nume)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramNume = DALHelper.ProviderFactory.CreateParameter();
            paramNume.ParameterName = "@nume";
            paramNume.Value = nume;

            paramList[0] = paramNume;

            db.ExecuteNonQuery(DALHelper.Connection, "AddMaterie", paramList);  
        }


        internal void UpdateMaterie(int id_materie, string nume)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramIdMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramIdMaterie.ParameterName = "@materieID";
            paramIdMaterie.Value = id_materie;

            DbParameter paramNume = DALHelper.ProviderFactory.CreateParameter();
            paramNume.ParameterName = "@nume";
            paramNume.Value = nume;

            paramList[0] = paramIdMaterie;
            paramList[1] = paramNume;

            db.ExecuteNonQuery(DALHelper.Connection, "UpdateMaterie", paramList);
            
        }

        internal void DeleteMaterie(int materieID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramIdMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramIdMaterie.ParameterName = "@materieID";
            paramIdMaterie.Value = materieID;

            paramList[0] = paramIdMaterie;

            db.ExecuteNonQuery(DALHelper.Connection, "DeleteMaterie", paramList);
            
        }

        public DataTable GetMaterieByProfId(int profID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramIdProf = DALHelper.ProviderFactory.CreateParameter();
            paramIdProf.ParameterName = "@profesorID";
            paramIdProf.Value = profID;

            paramList[0] = paramIdProf;

            return db.ExecuteDataSet(DALHelper.Connection, "GetMaterieByProfId", paramList);

        }
    }
}
