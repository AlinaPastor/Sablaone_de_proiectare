using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlatformaEducationala.DataAccessLayer;
using System.Data;

namespace PlatformaEducationala.BusinessLogicLayer
{
    class LoginBL
    {
        LoginDAL loginDAL = new LoginDAL();
        internal DataSet Login(string user, string parola, int tipUser)
        {
            DataSet result = new DataSet();
            switch (tipUser)
            {
                case 1:
                    {
                        result = loginDAL.LoginProfesor(user, parola);
                        break;
                    }
                case 2:
                    {
                        result = loginDAL.LoginDiriginte(user, parola);
                        break;

                    }
                case 3:
                    {
                        result = loginDAL.LoginElev(user, parola);
                        break;
                    }
                case 4:
                    {
                        result = loginDAL.LoginAdmin(user, parola);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return result;

        }

    }
}
