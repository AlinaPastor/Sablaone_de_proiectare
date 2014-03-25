using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class AbsentaBL
    {
        AbsentaDAL absDAL = new AbsentaDAL();

        public DataSet GetAbsenteByIDuri(int id_sem, int id_elev, int id_materie)
        {
            return absDAL.GetAbsenteByIDuri(id_sem,  id_elev, id_materie);
        }

        public DataSet GetAbsenteByIDElev(int id_elev)
        {
            return absDAL.GetAbsenteByIDElev(id_elev);
        }

        public DataSet GetAbsenteNemotivateByIDElev(int id_elev)
        {
            return absDAL.GetAbsenteNemotivateByIDElev(id_elev);
        }


        public DataSet GetAbsenteClasa(int id_clasa)
        {
            return absDAL.GetAbsenteClasa(id_clasa);
        }

        public DataSet GetAbsenteClasaNemotivate(int id_clasa)
        {
            return absDAL.GetAbsenteClasaNemotivate(id_clasa);
        }

        internal void AddAbsenta(int id_sem, int id_elev, int id_materie,  bool motivata, bool motivabila)
        {
            absDAL.AddAbsenta( id_sem, id_elev, id_materie, motivata, motivabila);
        }

        internal void MotivareAbsenta(int id_absenta)
        {
           absDAL.MotivareAbsenta(id_absenta);
        }

        public DataSet GetMotivabilitateById(int id_absenta)
        {
            return absDAL.GetMotivabilitateById(id_absenta);
        }


    }
}
