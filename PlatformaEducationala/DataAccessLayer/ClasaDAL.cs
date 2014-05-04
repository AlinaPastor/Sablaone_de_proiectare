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

        public DataTable GetClase()
        {
            return db.ExecuteDataSet(DALHelper.Connection, "GetClase", null);
        }

        public DataTable GetClasaById(int clasaID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramClasaId.ParameterName = "@clasaID";
            paramClasaId.Value = clasaID;

            paramList[0] = paramClasaId;

            return db.ExecuteDataSet(DALHelper.Connection, "GetClasaById", paramList);
        }

        internal void AddClasa(string nume)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramNume = DALHelper.ProviderFactory.CreateParameter();
            paramNume.ParameterName = "@nume";
            paramNume.Value = nume;

            paramList[0] = paramNume;


            db.ExecuteNonQuery(DALHelper.Connection, "AddClasa", paramList);

        }


        internal void UpdateClasa(int id_clasa, string nume)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramClasaId.ParameterName = "@clasaID";
            paramClasaId.Value = clasaID;

            DbParameter paramNume = DALHelper.ProviderFactory.CreateParameter();
            paramNume.ParameterName = "@nume";
            paramNume.Value = nume;

            paramList[0] = paramClasaId;
            paramList[1] = paramNume;

            db.ExecuteNonQuery(DALHelper.Connection, "UpdateClasa", paramList);

        }

        internal void DeleteClasa(int clasaID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramClasaId.ParameterName = "@clasaID";
            paramClasaId.Value = clasaID;

            paramList[0] = paramClasaId;

            db.ExecuteNonQuery(DALHelper.Connection, "DeleteClasa", paramList);
        }

        internal void AsocDiriginteClasa(int id_profrsor_dirig, int id_clasa)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramClasaId.ParameterName = "@clasaID";
            paramClasaId.Value = clasaID;

            DbParameter paramProfesorId = DALHelper.ProviderFactory.CreateParameter();
            paramProfesorId.ParameterName = "@profesorID";
            paramProfesorId.Value = id_profrsor_dirig;

            paramList[0] = paramClasaId;
            paramList[1] = paramProfesorId;

            db.ExecuteNonQuery(DALHelper.Connection, "AsocDiriginteClasa", paramList);

        }

        internal void AsocAn_StudiuClasa(int id_an_studiu, int id_clasa)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramClasaId.ParameterName = "@clasaID";
            paramClasaId.Value = clasaID;

            DbParameter paramAnStudiuId = DALHelper.ProviderFactory.CreateParameter();
            paramAnStudiuId.ParameterName = "@an_studiuID";
            paramAnStudiuId.Value = id_an_studiu;

            paramList[0] = paramClasaId;
            paramList[1] = paramAnStudiuId;


            db.ExecuteNonQuery(DALHelper.Connection, "AsocAn_StudiuClasa", paramList);

        }

        internal void AsocProfesorClasa(int id_profesor, int id_materie, int id_clasa, bool teza)
        {
            DbParameter[] paramList = new DbParameter[4];

            DbParameter paramClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramClasaId.ParameterName = "@clasaID";
            paramClasaId.Value = id_clasa;

            DbParameter paramMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramMaterie.ParameterName = "@materieID";
            paramMaterie.Value = id_materie;

            DbParameter paramProfesorId = DALHelper.ProviderFactory.CreateParameter();
            paramProfesorId.ParameterName = "@profesorID";
            paramProfesorId.Value = id_profesor;

            DbParameter paramTeza = DALHelper.ProviderFactory.CreateParameter();
            paramTeza.ParameterName = "@teza";
            paramTeza.Value = teza;

            paramList[0] = paramClasaId;
            paramList[1] = paramProfesorId;
            paramList[2] = paramMaterie;
            paramList[3] = paramTeza;

            db.ExecuteNonQuery(DALHelper.Connection, "AsocProfesorClasa", paramList);
        }

        internal DataTable GetIdForProfMaterieClasaTeza(int id_profesor, int id_materie, int id_clasa, bool teza)
        {
            DbParameter[] paramList = new DbParameter[4];

            DbParameter paramClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramClasaId.ParameterName = "@clasaID";
            paramClasaId.Value = id_clasa;

            DbParameter paramMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramMaterie.ParameterName = "@materieID";
            paramMaterie.Value = id_materie;

            DbParameter paramProfesorId = DALHelper.ProviderFactory.CreateParameter();
            paramProfesorId.ParameterName = "@profesorID";
            paramProfesorId.Value = id_profesor;

            DbParameter paramTeza = DALHelper.ProviderFactory.CreateParameter();
            paramTeza.ParameterName = "@teza";
            paramTeza.Value = teza;

            paramList[0] = paramClasaId;
            paramList[1] = paramProfesorId;
            paramList[2] = paramMaterie;
            paramList[3] = paramTeza;

            return db.ExecuteDataSet(DALHelper.Connection, "GerIdForProfMaterieClasaTeza", paramList);

        }

        internal void UpdateAsocProfesorClasa(int id_prof_clasa, int id_profesor)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramProfesorId = DALHelper.ProviderFactory.CreateParameter();
            paramProfesorId.ParameterName = "@profesorID";
            paramProfesorId.Value = id_profesor;

            DbParameter paramProfesorClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramProfesorClasaId.ParameterName = "@prof_clasaID";
            paramProfesorClasaId.Value = id_prof_clasa;

            paramList[0] = paramProfesorClasaId;
            paramList[1] = paramProfesorId;

            db.ExecuteNonQuery(DALHelper.Connection, "UpdateAsocProfesorClasa", paramList);
        }


        public DataTable GetClasaByProfMatId(int profID, int matID)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramMaterie.ParameterName = "@materieID";
            paramMaterie.Value = id_materie;

            DbParameter paramProfesorId = DALHelper.ProviderFactory.CreateParameter();
            paramProfesorId.ParameterName = "@profesorID";
            paramProfesorId.Value = id_profesor;

            paramList[0] = paramMaterie;
            paramList[1] = paramProfesorId;

            return db.ExecuteDataSet(DALHelper.Connection, "GetClasaByProfMatId", paramList);

        }

        public DataTable VerifTeza(int matID, int clasaID)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter paramMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramMaterie.ParameterName = "@materieID";
            paramMaterie.Value = id_materie;

            DbParameter paramClasaId = DALHelper.ProviderFactory.CreateParameter();
            paramClasaId.ParameterName = "@clasaID";
            paramClasaId.Value = id_clasa;

            paramList[0] = paramMaterie;
            paramList[1] = paramClasaId;

            return db.ExecuteDataSet(DALHelper.Connection, "VerifTeza", paramList);

        }
    }
}
