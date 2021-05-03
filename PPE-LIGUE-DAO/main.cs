using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE_LIGUE_DAO
{
    public partial class main : Form
    {
        private Dictionary<Int32, Partenaire> lesPartenaires = new Dictionary<Int32, Partenaire>();
        private Dictionary<Int32, TypePartenaire> lesType = new Dictionary<Int32, TypePartenaire>();
        private Dictionary<String, TypePartenaire> lesTypeParNom = new Dictionary<String, TypePartenaire>();
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
            foreach (var v in this.lesType)
            {
                ComboTypePart.Items.Add(v.Value.GetLabel());
            }
            
        }

        public int GetPartenaireTypeIdByLabel(string label) // Old function, not used anymore
        {
            foreach (var v in this.lesType)
            {
                if (v.Value.GetLabel() == label)
                {
                    return v.Value.GetId();
                }
            }

            return 1; // Default return 
        }

        public void GetAllPartenaire()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM partenaire";
            SqlDataReader reader = db.excecSQLRead(req);

            Dictionary<Int32, Partenaire> lesPartenaires = new Dictionary<Int32, Partenaire>();
            
            while (reader.Read())
            {
                Partenaire part = new Partenaire(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                lesPartenaires.Add(Int32.Parse(reader[0].ToString()), part);
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

            Dictionary<Int32, TypePartenaire> lesTypes = new Dictionary<Int32, TypePartenaire>();
            
            while (reader.Read())
            {
                TypePartenaire part = new TypePartenaire(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                lesTypes.Add(Int32.Parse(reader[0].ToString()), part);
                lesTypeParNom.Add(reader[1].ToString(), part);
            }

            db.deconnecter();
            this.lesType = lesTypes;
        }

        private void BtnCreationPartenaire_Click(object sender, EventArgs e)
        {
            string name = TxtBoxCreatePartName.Text;
            object selectedTypeLabel = ComboTypePart.SelectedItem;
            int id = lesTypeParNom[selectedTypeLabel.ToString()].GetId();
            
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "INSERT INTO partenaire VALUES ('" + id +"', '" + name +"')";
            db.execSQLWrite(req);
            
            MessageBox.Show("name: " + name + "\nType: " + selectedTypeLabel.ToString() + "\nAjouté !");
        }
    }
}