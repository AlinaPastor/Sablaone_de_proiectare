using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace PlatformaEducationala.DataAccessLayer
{
    class MedieSemestruDAL
    {
        DatabaseAccess db = new DatabaseAccess();
        public DataTable GetMedieSemByIDuri(int id_sem, int id_elev, int id_materie)
        {
            DbParameter[] paramList = new DbParameter[3];

            DbParameter paramIdSem = DALHelper.ProviderFactory.CreateParameter();
            paramIdSem.ParameterName = "@semestruID";
            paramIdSem.Value = id_sem;

            DbParameter paramIdElev = DALHelper.ProviderFactory.CreateParameter();
            paramIdElev.ParameterName = "@elevID";
            paramIdElev.Value = id_elev;

            DbParameter paramIdMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramIdMaterie.ParameterName = "@materieID";
            paramIdMaterie.Value = id_materie;

            paramList[0] = paramIdSem;
            paramList[1] = paramIdElev;
            paramList[2] = paramIdMaterie;

            return db.ExecuteDataSet(DALHelper.Connection, "GetMedieSemByIDuri", paramList);
        }

        internal void AddMedie(int id_elev, int id_materie, int id_sem, int media)
        {
            DbParameter[] paramList = new DbParameter[4];

            DbParameter paramIdElev = DALHelper.ProviderFactory.CreateParameter();
            paramIdElev.ParameterName = "@elevID";
            paramIdElev.Value = id_elev;

            DbParameter paramIdMaterie = DALHelper.ProviderFactory.CreateParameter();
            paramIdMaterie.ParameterName = "@materieID";
            paramIdMaterie.Value = id_materie;

            DbParameter paramIdSem = DALHelper.ProviderFactory.CreateParameter();
            paramIdSem.ParameterName = "@semestruID";
            paramIdSem.Value = id_sem;

            DbParameter paramMedia = DALHelper.ProviderFactory.CreateParameter();
            paramMedia.ParameterName = "@medie";
            paramMedia.Value = media;

            
            paramList[0] = paramIdElev;
            paramList[1] = paramIdMaterie;
            paramList[2] = paramIdSem;
            paramList[3] = paramMedia;

            db.ExecuteNonQuery(DALHelper.Connection, "AddMedie", paramList);
        }
    }
}
