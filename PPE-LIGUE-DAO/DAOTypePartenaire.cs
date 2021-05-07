using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PPE_LIGUE_DAO
{
    public class DAOTypePartenaire
    {
        public static Dictionary<Int32, TypePartenaire> GetAllTypePartenaire()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM typePartenaire";
            SqlDataReader reader = db.excecSQLRead(req);
        
            Dictionary<Int32, TypePartenaire> lesTypes = new Dictionary<Int32, TypePartenaire>();

            while (reader.Read())
            {
                TypePartenaire part = new TypePartenaire(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                lesTypes.Add(Int32.Parse(reader[0].ToString()), part);
            }
        
            db.deconnecter();
            //this.lesType = lesTypes;
            return lesTypes;
        }
        
        public static Dictionary<String, TypePartenaire> GetAllTypePartenaireByName()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM typePartenaire";
            SqlDataReader reader = db.excecSQLRead(req);
        
            Dictionary<String, TypePartenaire> lesTypes = new Dictionary<String, TypePartenaire>();

            while (reader.Read())
            {
                TypePartenaire part = new TypePartenaire(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                lesTypes.Add(reader[1].ToString(), part);
            }
        
            db.deconnecter();
            //this.lesType = lesTypes;
            return lesTypes;
        }
    }
}