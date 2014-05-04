using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class NotaDAL
    {

        DatabaseAccess db = new DatabaseAccess();

        public DataTable GetNoteByIDuri(int id_elev, int id_materie, int id_sem)
        {

        
           DbParameter[] paramList = new DbParameter[3];

           DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
           param1.ParameterName = "@elevID";
           param1.Value = id_elev;

           DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
           param2.ParameterName = "@materieID";
           param2.Value = id_materie;

             DbParameter param3 = DALHelper.ProviderFactory.CreateParameter();
           param3.ParameterName = "@semestruID";
           param3.Value = id_sem;


           paramList[0] = param1;
           paramList[1] = param2;
           paramList[2] = param3;
           return db.ExecuteDataSet(DALHelper.Connection, "GetNoteByIDuri", paramList);


        }

        public DataTable GetNoteByIDuri1(int id_elev, int id_materie, int id_sem)
        {

            DbParameter[] paramList = new DbParameter[3];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@elevID";
            param1.Value = id_elev;

            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@materieID";
            param2.Value = id_materie;

            DbParameter param3 = DALHelper.ProviderFactory.CreateParameter();
            param3.ParameterName = "@semestruID";
            param3.Value = id_sem;


            paramList[0] = param1;
            paramList[1] = param2;
            paramList[2] = param3;
            return db.ExecuteDataSet(DALHelper.Connection, "GetNoteByIDuri1", paramList);
          
    
        }

        public DataTable GetTezaByIDuri(int id_elev, int id_materie, int id_sem)
        {

            DbParameter[] paramList = new DbParameter[3];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@elevID";
            param1.Value = id_elev;

            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@materieID";
            param2.Value = id_materie;

            DbParameter param3 = DALHelper.ProviderFactory.CreateParameter();
            param3.ParameterName = "@semestruID";
            param3.Value = id_sem;


            paramList[0] = param1;
            paramList[1] = param2;
            paramList[2] = param3;
            return db.ExecuteDataSet(DALHelper.Connection, "GetTezaByIDuri", paramList);  
       }

        internal void AddNota(int id_elev, int id_materie, int id_sem, int nota)
        {


            DbParameter[] paramList = new DbParameter[4];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@elevID";
            param1.Value = id_elev;

            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@materieID";
            param2.Value = id_materie;

            DbParameter param3 = DALHelper.ProviderFactory.CreateParameter();
            param3.ParameterName = "@semestruID";
            param3.Value = id_sem;

            DbParameter param4 = DALHelper.ProviderFactory.CreateParameter();
            param4.ParameterName = "@nota";
            param4.Value = nota;


            paramList[0] = param1;
            paramList[1] = param2;
            paramList[2] = param3;
            paramList[3] = param4;

            db.ExecuteDataSet(DALHelper.Connection, "AddNota", paramList);     
        }

        internal void DeleteNota(int id_nota)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@notaID";
            param1.Value = id_nota;

            paramList[0] = param1;

            db.ExecuteNonQuery(DALHelper.Connection, "DeleteNota", paramList);  
           
        }

        internal void AddTeza(int id_elev, int id_materie, int id_sem, int teza)
        {
            DbParameter[] paramList = new DbParameter[4];

            DbParameter param1 = DALHelper.ProviderFactory.CreateParameter();
            param1.ParameterName = "@elevID";
            param1.Value = id_elev;

            DbParameter param2 = DALHelper.ProviderFactory.CreateParameter();
            param2.ParameterName = "@materieID";
            param2.Value = id_materie;

            DbParameter param3 = DALHelper.ProviderFactory.CreateParameter();
            param3.ParameterName = "@semestruID";
            param3.Value = id_sem;

            DbParameter param4 = DALHelper.ProviderFactory.CreateParameter();
            param4.ParameterName = "@teza";
            param4.Value = teza;


            paramList[0] = param1;
            paramList[1] = param2;
            paramList[2] = param3;
            paramList[3] = param4;
             db.ExecuteNonQuery(DALHelper.Connection, "AddTeza", paramList);
       
        }

    }
}
