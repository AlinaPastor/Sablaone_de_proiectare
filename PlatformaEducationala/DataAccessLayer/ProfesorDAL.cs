using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class ProfesorDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataTable GetProfesori()
        {
            return db.ExecuteDataSet(DALHelper.Connection, "GetProfesori", null);
        }

        public DataTable GetProfesoriById(int profesorID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@profesorID";
            param1.Value = profesorID;

            paramList[0] = param1;
           
            return db.ExecuteDataSet(DALHelper.Connection, "GetProfesoriById", paramList);
          
        }

        public DataTable GetProfesoriByMaterieId(int materieID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@materieID";
            param1.Value = materieID;

            paramList[0] = param1;
         
            return db.ExecuteDataSet(DALHelper.Connection, "GetProfesoriByMaterieId", paramList);
      
        }
        internal void AddProfesor(string nume, string prenume, string user, string parola)
        {
            DbParameter[] paramList = new DbParameter[4];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@nume";
            param1.Value = nume;

            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@prenume";
            param2.Value = prenume;

            DbParameter param3 = DALHelper.ProviderFactory.CreateParameter();
            param3.ParameterName = "@user";
            param3.Value = user;

            DbParameter param4 = DALHelper.ProviderFactory.CreateParameter();
            param4.ParameterName = "@parola";
            param4.Value = parola;


            paramList[0] = param1;
            paramList[1] = param2;
            paramList[2] = param3;
            paramList[3] = param4;
            db.ExecuteNonQuery(DALHelper.Connection, "AddProfesor", paramList);
        }


        internal void UpdateProfesor(int id_profesor, string nume, string prenume, string user, string parola)
        {

            DbParameter[] paramList = new DbParameter[5];

            DbParameter param0 = DALHelper.ProviderFactory.CreateParameter();
            param0.ParameterName = "@profesorID";
            param0.Value = id_profesor;

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@nume";
            param1.Value = nume;

            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@prenume";
            param2.Value = prenume;

            DbParameter param3 = DALHelper.ProviderFactory.CreateParameter();
            param3.ParameterName = "@user";
            param3.Value = user;

            DbParameter param4 = DALHelper.ProviderFactory.CreateParameter();
            param4.ParameterName = "@parola";
            param4.Value = parola;


            paramList[0] = param0;
            paramList[1] = param1;
            paramList[2] = param2;
            paramList[3] = param3;
            paramList[4] = param4;
        
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateProfesor", paramList);
        }

        internal void DeleteProfesor(int profesorID)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter param0 = DALHelper.ProviderFactory.CreateParameter();
            param0.ParameterName = "@profesorID";
            param0.Value = profesorID;

            paramList[0] = param0;

            db.ExecuteNonQuery(DALHelper.Connection, "DeleteProfesor", paramList);
        }

        internal void AsocProfesorMaterie(int id_profesor, int id_materie)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter param0 = DALHelper.ProviderFactory.CreateParameter();
            param0.ParameterName = "@profesorID";
            param0.Value = id_profesor;

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@materieID";
            param1.Value = id_materie;

            paramList[0] = param0;
            paramList[1] = param1;
          
            db.ExecuteNonQuery(DALHelper.Connection, "AsocProfesorMaterie", paramList);
        }

        public DataTable GetIdForProfMaterie(int id_materie, int id_profesor)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@materieID";
            param1.Value = id_materie;


            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@profesorID";
            param2.Value = id_profesor;

            paramList[0] = param1;
            paramList[1] = param2;
        
            return db.ExecuteDataSet(DALHelper.Connection, "GerIdForProfMaterie", paramList);
  
        }


        internal void UpdateAsocProfesorMaterie(int id_prof_materie,  int id_profesor)
        {
            DbParameter[] paramList = new DbParameter[2];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@prof_materieID";
            param1.Value = id_prof_materie;


            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@profesorID";
            param2.Value = id_profesor;

            paramList[0] = param1;
            paramList[1] = param2;
        
          
            db.ExecuteNonQuery(DALHelper.Connection, "UpdateAscoProfesorMaterie", paramList);
        }
    }
}
