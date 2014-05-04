using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class MaterieBL
    {

        MaterieDAL materieDAL = new MaterieDAL();
        public DataTable GetMaterii()
        {
            return materieDAL.GetMaterii();
        }

        public DataTable GetMaterieById(int materieID)
        {
            return materieDAL.GetMaterieById(materieID);
        }

        internal void AddMaterie(string nume)
        {
            materieDAL.AddMaterie(nume);
        }

        internal void UpdateMaterie(int materieID, string nume)
        {
            materieDAL.UpdateMaterie(materieID, nume);
        }

        internal void DeleteMaterie(int materieID)
        {
            materieDAL.DeleteMaterie(materieID);
        }

        public DataTable GetMaterieByProfId(int profID)
        {
            return materieDAL.GetMaterieByProfId(profID);
        }
    }
}
