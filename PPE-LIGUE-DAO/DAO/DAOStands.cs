using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PPE_LIGUE_DAO
{
    public class DAOStands
    {
        public static Dictionary<Int32, Stands> GetAllStands()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM stand";
            SqlDataReader reader = db.excecSQLRead(req);

            Dictionary<Int32, Stands> lesStands = new Dictionary<int, Stands>();

            while (reader.Read())
            {
                Stands stand = new Stands(Int32.Parse(reader[0].ToString()), reader[1].ToString(), Int32.Parse(reader[2].ToString()), Int32.Parse(reader[3].ToString()), Int32.Parse(reader[4].ToString()));
                lesStands.Add(Int32.Parse(reader[4].ToString()), stand);
            }

            db.deconnecter();
            return lesStands;
        }
        
    }
}