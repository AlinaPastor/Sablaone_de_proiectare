using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PlatformaEducationala.DataAccessLayer;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class ProfesorBL
    {
        ProfesorDAL profesorDAL = new ProfesorDAL();
        public DataTable GetProfesori()
        {
            return profesorDAL.GetProfesori();
        }

        public DataTable GetProfesoriById(int profesorID)
        {
            return profesorDAL.GetProfesoriById(profesorID);
        }

        public DataTable GetProfesoriByMaterieId(int materieID)
        {
            return profesorDAL.GetProfesoriByMaterieId(materieID);
        }

        internal void AddProfesor(string nume, string prenume, string user, string parola)
        {
            profesorDAL.AddProfesor(nume, prenume, user, parola);
        }

        internal void UpdateProfesor(int profesorID, string nume, string prenume, string user, string parola)
        {
            profesorDAL.UpdateProfesor(profesorID, nume, prenume, user, parola);
        }


        internal void DeleteProfesor(int profesorID)
        {
            profesorDAL.DeleteProfesor(profesorID);
        }

        internal void AsocProfesorMaterie(int profesorID, int materieID) 
        {
            profesorDAL.AsocProfesorMaterie(profesorID, materieID);
        }

        internal DataTable GetIdForProfMaterie(int materieID, int profesorID)
        {
            return profesorDAL.GetIdForProfMaterie( materieID, profesorID);
        }

        internal void UpdateAsocProfesorMaterie(int id_prof_materie, int id_profesor)
        {
            profesorDAL.UpdateAsocProfesorMaterie(id_prof_materie,  id_profesor);
        }



    }
}
