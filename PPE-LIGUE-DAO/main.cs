using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE_LIGUE_DAO
{
    public partial class main : Form
    {
        private List<Partenaire> lesPartenaires = new List<Partenaire>();
        private List<TypePartenaire> lesType = new List<TypePartenaire>();
        public main()
        {
            InitializeComponent();
            this.LoadCreationPartenaireData();
        }

        public void LoadCreationPartenaireData()
        {
            GetAllPartenaire();
            GetAllTypePartenaire();
            
            ComboTypePart.Items.Clear();
            foreach (var v in this.lesPartenaires)
            {
                ComboTypePart.Items.Add(v.GetLabel());
            }
            
        }


        public void GetAllPartenaire()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM partenaire";
            SqlDataReader reader = db.excecSQLRead(req);

            List<Partenaire> lesPartenaires = new List<Partenaire>();
            
            while (reader.Read())
            {
                Partenaire part = new Partenaire(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                lesPartenaires.Add(part);
            }

            db.deconnecter();
            this.lesPartenaires = lesPartenaires;
        }
        
        public void GetAllTypePartenaire()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM typePartenaire";
            SqlDataReader reader = db.excecSQLRead(req);

            List<TypePartenaire> lesTypes = new List<TypePartenaire>();
            
            while (reader.Read())
            {
                TypePartenaire part = new TypePartenaire(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                lesTypes.Add(part);
            }

            db.deconnecter();
            this.lesType = lesTypes;
        }
    }
}