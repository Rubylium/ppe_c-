using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PPE_LIGUE_DAO
{
    public class loginDAO
    {
        public static bool TryLogin(String login, String password)
        {
            string req = "Select * from utilisateur where login = " + login + " and password = " + password;
            DAOFactory db = new DAOFactory();
            db.connecter();
            
            SqlDataReader reader = db.excecSQLRead(req);

            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            if (count != 0)
            {
                return true;
            }

            return false;
        }
    }
}