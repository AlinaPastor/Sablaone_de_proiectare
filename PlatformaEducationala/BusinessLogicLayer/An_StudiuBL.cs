using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class An_StudiuBL
    {

       An_StudiuDAL anDAL = new An_StudiuDAL();
        public DataSet GetAni_Studiu()
        {
            return anDAL.GetAni_Studiu();
        }

        public DataSet GetAn_StudiuById(int anID)
        {
            return anDAL.GetAn_StudiuById(anID);
        }

        internal void AddAn_Studiu(string an)
        {
            anDAL.AddAn_Studiu(an);
        }

        internal void UpdateAn_Studiu(int anID, string an)
        {
            anDAL.UpdateAn_Studiu(anID, an);
        }

        internal void DeleteAn_Studiu(int anID)
        {
            anDAL.DeleteAn_Studiu(anID);
        }


     
    }
}
