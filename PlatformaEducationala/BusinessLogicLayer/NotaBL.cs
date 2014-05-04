using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class NotaBL
    {
        NotaDAL notaDAL = new NotaDAL();

        public DataTable GetNoteByIDuri(int id_elev, int id_materie, int id_sem)
        {
            return notaDAL.GetNoteByIDuri(id_elev,  id_materie,  id_sem);
        }

        public DataTable GetNoteByIDuri1(int id_elev, int id_materie, int id_sem)
        {
            return notaDAL.GetNoteByIDuri1(id_elev, id_materie, id_sem);
        }

        public DataTable GetTezaByIDuri(int id_elev, int id_materie, int id_sem)
        {
            return notaDAL.GetTezaByIDuri(id_elev, id_materie, id_sem);
        }

        internal void AddNota(int id_elev, int id_materie, int id_sem, int nota)
        {
            notaDAL.AddNota( id_elev, id_materie, id_sem, nota);
        }

        internal void DeleteNota(int id_nota)
        {
            notaDAL.DeleteNota(id_nota);
        }

        internal void AddTeza(int id_elev, int id_materie, int id_sem, int teza)
        {
            notaDAL.AddTeza(id_elev, id_materie, id_sem, teza);
        }
    }
}
