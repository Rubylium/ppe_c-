using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PPE_LIGUE_DAO
{
    public class DAOEquipement
    {
        public static Dictionary<String, Equipement> GetAllEquipement()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM equipement";
            SqlDataReader reader = db.excecSQLRead(req);

            Dictionary<String, Equipement> lesEquipement = new Dictionary<string, Equipement>();

            while (reader.Read())
            {
                Equipement equip = new Equipement(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                lesEquipement.Add(reader[1].ToString(), equip);
            }

            db.deconnecter();
            return lesEquipement;
        }
        
        public static Dictionary<Int32, Equipement> GetAllEquipementWithId()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM equipement";
            SqlDataReader reader = db.excecSQLRead(req);

            Dictionary<Int32, Equipement> lesEquipement = new Dictionary<Int32, Equipement>();

            while (reader.Read())
            {
                Equipement equip = new Equipement(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                lesEquipement.Add(Int32.Parse(reader[0].ToString()), equip);
            }

            db.deconnecter();
            return lesEquipement;  
        }
    }
}