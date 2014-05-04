using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class MedieSemestruBL
    {
        MedieSemestruDAL medDAL = new MedieSemestruDAL();

        public DataTable GetMedieSemIDuri(int id_sem, int id_elev, int id_materie)
        {
            return medDAL.GetMedieSemByIDuri(id_sem, id_elev, id_materie);
        }

        internal void AddMedie(int id_elev, int id_materie, int id_sem, int media)
        {
            medDAL.AddMedie(id_elev, id_materie, id_sem, media);
        }
    }
}
