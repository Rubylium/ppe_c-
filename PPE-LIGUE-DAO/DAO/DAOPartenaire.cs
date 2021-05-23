using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PPE_LIGUE_DAO
{
    public class DAOPartenaire
    {
        public static List<Partenaire> GetAllPartenaire()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM partenaire";
            SqlDataReader reader = db.excecSQLRead(req);

            List<Partenaire> lesPartenaires = new List<Partenaire>();
            
            while (reader.Read())
            {
                Partenaire part = new Partenaire(Int32.Parse(reader[0].ToString()), reader[1].ToString(), Int32.Parse(reader[2].ToString()));
                lesPartenaires.Add(part);
            }

            db.deconnecter();
            //this.lesPartenaires = lesPartenaires;
            return lesPartenaires;
        }
    }
}