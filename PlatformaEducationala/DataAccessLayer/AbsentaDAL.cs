using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class AbsentaDAL
    {
        DatabaseAccess db = new DatabaseAccess();

        public DataTable GetAbsenteByIDuri(int id_sem, int id_elev, int id_materie)
        {
            DbParameter[] paramList = new DbParameter[3];

            DbParameter paramSem = DALHelper.ProviderFactory.CreateParameter();
            paramSem.ParameterName = "@semestruID";
            paramSem.Value = id_sem;

            DbParameter paramElev = DALHelper.ProviderFactory.CreateParameter();
            paramElev.ParameterName = "@elevID";
            paramElev.Value = id_elev;

            DbParameter paramMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramMaterie.ParameterName = "@materieID";
            paramMaterie.Value = id_materie;

            paramList[0] = paramSem;
            paramList[1] = paramElev;
            paramList[2] = paramMaterie;

            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteByIDuri", paramList);
        }

        public DataTable GetAbsenteByIDElev(int id_elev)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramElev = DALHelper.ProviderFactory.CreateParameter();
            paramElev.ParameterName = "@elevID";
            paramElev.Value = id_elev;

            paramList[0] = paramElev;
            
            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteByIDElev", paramList);
        }

        public DataTable GetAbsenteNemotivateByIDElev(int id_elev)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramElev = DALHelper.ProviderFactory.CreateParameter();
            paramElev.ParameterName = "@elevID";
            paramElev.Value = id_elev;

            paramList[0] = paramElev;

            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteNemotivateByIDElev", paramList);
        }

        public DataTable GetAbsenteClasa(int id_clasa)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramClasa = DALHelper.ProviderFactory.CreateParameter();
            paramClasa.ParameterName = "@clasaID";
            paramClasa.Value = id_clasa;

            paramList[0] = paramClasa;
       
            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteClasa", paramList);
        }

        public DataTable GetAbsenteClasaNemotivate(int id_clasa)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramClasa = DALHelper.ProviderFactory.CreateParameter();
            paramClasa.ParameterName = "@clasaID";
            paramClasa.Value = id_clasa;

            paramList[0] = paramClasa;
           
            return db.ExecuteDataSet(DALHelper.Connection, "GetAbsenteClasaNemotivate", paramList);
           
        } 
        internal void AddAbsenta(int id_sem, int id_elev, int id_materie, bool motivata, bool motivabila)
        {
            DbParameter[] paramList = new DbParameter[5];

            DbParameter paramElev = DALHelper.ProviderFactory.CreateParameter();
            paramElev.ParameterName = "@elevID";
            paramElev.Value = id_elev;

            DbParameter paramSem = DALHelper.ProviderFactory.CreateParameter();
            paramSem.ParameterName = "@semestruID";
            paramSem.Value = id_sem;

            DbParameter paramMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramMaterie.ParameterName = "@materieID";
            paramMaterie.Value = id_materie;

            DbParameter paramMotivata = DALHelper.ProviderFactory.CreateParameter();
            paramMotivata.ParameterName = "@motivata";
            paramMotivata.Value = motivata;

            DbParameter paramMotivabila = DALHelper.ProviderFactory.CreateParameter();
            paramMotivabila.ParameterName = "@motivabila";
            paramMotivabila.Value = motivabila;

            paramList[0] = paramElev;
            paramList[1] = paramSem;
            paramList[2] = paramMaterie;
            paramList[3] = paramMotivata;
            paramList[4] = paramMotivabila;

            db.ExecuteNonQuery(DALHelper.Connection, "AddAbsenta", paramList);
        }

        internal void MotivareAbsenta(int id_absenta)
        {
            DbParameter[] paramList = new DbParameter[1];

            DbParameter paramAbsenta = DALHelper.ProviderFactory.CreateParameter();
            paramAbsenta.ParameterName = "@absentaID";
            paramAbsenta.Value = id_absenta;

            paramList[0] = paramAbsenta;

            db.ExecuteNonQuery(DALHelper.Connection, "MotivareAbsenta", paramList);
        }

        public DataTable GetMotivabilitateById(int id_absenta)
        {
             DbParameter[] paramList = new DbParameter[1];

            DbParameter paramAbsenta = DALHelper.ProviderFactory.CreateParameter();
            paramAbsenta.ParameterName = "@absentaID";
            paramAbsenta.Value = id_absenta;

            paramList[0] = paramAbsenta;

            return db.ExecuteDataSet(DALHelper.Connection, "GetMotivabilitateById", paramList);
        }

    }

}
