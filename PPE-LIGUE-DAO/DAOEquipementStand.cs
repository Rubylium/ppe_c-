using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PPE_LIGUE_DAO
{
    public class DAOEquipementStand
    {
        public static List<EquipementStands> GetAllEquipementStand()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM equipementStand";
            SqlDataReader reader = db.excecSQLRead(req);

            List<EquipementStands> lesEquipementDeStand = new List<EquipementStands>();

            while (reader.Read())
            {
                EquipementStands equipement = new EquipementStands(Int32.Parse(reader[2].ToString()), Int32.Parse(reader[0].ToString()), Int32.Parse(reader[1].ToString()));
                lesEquipementDeStand.Add(equipement);
            }

            db.deconnecter();
            return lesEquipementDeStand;
        }
        
    }
}