using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class SemestruBL
    {
        SemestruDAL semDAL = new SemestruDAL();

        public DataTable GetSemestre()
        {
            return semDAL.GetSemestre();
        }

        public DataTable GetSemestruById(int semID)
        {
            return semDAL.GetSemestruById(semID);
        }

        internal void AsocAn_StudiuSemestru(int semID, int an_studiuID)
        {

            semDAL.AsocAn_StudiuSemestru(semID, an_studiuID);
        }
    }
}
