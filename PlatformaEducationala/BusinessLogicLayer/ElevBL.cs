using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class ElevBL
    {
        ElevDAL elevDAL = new ElevDAL();
        public DataTable GetElevi()
        {
            return elevDAL.GetElevi();
        }

        public DataTable GetEleviFaraClasa()
        {
            return elevDAL.GetEleviFaraClasa();
        }

        public DataTable GetEleviById(int elevID)
        {
            return elevDAL.GetEleviById(elevID);
        }

        internal void AddElev(string nume, string prenume, string user, string parola)
        {
            elevDAL.AddElev(nume, prenume, user, parola);
        }

        internal void UpdateElev(int elevID, string nume, string prenume, string user, string parola)
        {
            elevDAL.UpdateElev(elevID, nume, prenume, user, parola);
        }


        internal void DeleteElev(int elevID)
        {
            elevDAL.DeleteElev(elevID);
        }

        internal void AsocElevClasa(int elevID, int clasaID)
        {
            elevDAL.AsocElevClasa(elevID,clasaID);
        }

        public DataTable GetEleviByClasaId(int clasaID)
        {
            return elevDAL.GetEleviByClasaId(clasaID);
        }


    }
}
