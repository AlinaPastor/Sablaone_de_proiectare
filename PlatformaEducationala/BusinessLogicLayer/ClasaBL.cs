using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class ClasaBL
    {
        ClasaDAL clasaDAL = new ClasaDAL();
        public DataTable GetClase()
        {
            return clasaDAL.GetClase();
        }

        public DataTable GetClasaById(int clasaID)
        {
            return clasaDAL.GetClasaById(clasaID);
        }

        internal void AddClasa(string nume)
        {
            clasaDAL.AddClasa(nume);
        }

        internal void UpdateClasa(int clasaID, string nume)
        {
            clasaDAL.UpdateClasa(clasaID, nume);
        }

        internal void DeleteClasa(int clasaID)
        {
            clasaDAL.DeleteClasa(clasaID);
        }

        internal void AsocDiriginteClasa(int profesorID, int clasaID)
        {

            clasaDAL.AsocDiriginteClasa(profesorID, clasaID);
        }

        internal void AsocAn_StudiuClasa(int an_studiuID, int clasaID)
        {

            clasaDAL.AsocAn_StudiuClasa(an_studiuID, clasaID);
        }

        internal void AsocProfesorClasa(int id_profesor, int id_materie, int id_clasa, bool teza)
        {
            clasaDAL.AsocProfesorClasa(id_profesor, id_materie, id_clasa,teza);
        }

        internal DataTable GetIdForProfMaterieClasaTeza(int id_profesor, int id_materie, int id_clasa, bool teza)
        {
            return clasaDAL.GetIdForProfMaterieClasaTeza( id_profesor, id_materie, id_clasa, teza);
        }

        internal void UpdateAsocProfesorClasa(int id_prof_clasa, int id_profesor)
        {
            clasaDAL.UpdateAsocProfesorClasa(id_prof_clasa, id_profesor);
        }

        public DataTable GetClasaByProfMatId(int profID, int matID)
        {
            return clasaDAL.GetClasaByProfMatId(profID, matID);
        }

        public DataTable VerifTeza(int matID, int clasaID)
        {
            return clasaDAL.VerifTeza( matID, clasaID);
        }
    }
}
