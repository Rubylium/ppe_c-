using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE_LIGUE_DAO
{
    public partial class main : Form
    {
        private List<Partenaire> lesPartenaires = new List<Partenaire>(); // Not used anymore
        private Dictionary<Int32, TypePartenaire> lesType = new Dictionary<Int32, TypePartenaire>();
        private Dictionary<String, TypePartenaire> lesTypeParNom = new Dictionary<String, TypePartenaire>();
        private Dictionary<Int32, Equipement> lesEquipement = new Dictionary<Int32, Equipement>();
        private Dictionary<Int32, Stands> lesStands = new Dictionary<Int32, Stands>();
        public main()
        {
            InitializeComponent();
            this.LoadCreationPartenaireData();
        }

        public void LoadCreationPartenaireData()
        {
            GetAllPartenaire();
            GetAllTypePartenaire();
            GetAllEquipement();
            GetAllStands();
            
            ComboTypePart.Items.Clear();
            ComboAffectPartenaire.Items.Clear();
            ComboAffectStand.Items.Clear();
            ComboAffectStand.ResetText();
            ComboAffectPartenaire.ResetText();
            DataGridViewAffect.Rows.Clear();
            foreach (var v in this.lesType)
            {
                ComboTypePart.Items.Add(v.Value.GetLabel());
            }
            foreach (var v in this.lesPartenaires)
            {
                ComboAffectPartenaire.Items.Add(v.GetLabel());
            }

            foreach (var v in this.lesStands)
            {
                ComboAffectStand.Items.Add(v.Value.GetId());
                DataGridViewAffect.Rows.Add(v.Value.GetId(), v.Value.GetnAlle(), v.Value.GetnOrdre(), v.Value.GetSurface(), GetPartenaireLabelById(v.Value.GetIdPartenaire()));
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
        public string GetPartenaireLabelById(int id)
        {
            foreach (var v in this.lesPartenaires)
            {
                if (v.GetIdPartenaire() == id)
                {
                    return v.GetLabel();
                }
            }

            return "Aucun"; // Default return 
        }
        
        public int GetPartenaireIdByLabel(string label)
        {
            foreach (var v in this.lesPartenaires)
            {
                if (v.GetLabel() == label)
                {
                    return v.GetIdPartenaire();
                }
            }

            return 1; // Default return 
        }

        public bool DoesPartenaireAlreadyExistByName(string label)
        {
            var found = false;
            foreach (var v in this.lesPartenaires)
            {
                if (v.GetLabel() == label)
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

        public void GetAllStands()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM stand";
            SqlDataReader reader = db.excecSQLRead(req);

            this.lesStands.Clear();

            while (reader.Read())
            {
                Stands stand = new Stands(Int32.Parse(reader[0].ToString()), reader[1].ToString(), Int32.Parse(reader[2].ToString()), Int32.Parse(reader[3].ToString()), Int32.Parse(reader[4].ToString()));
                this.lesStands.Add(Int32.Parse(reader[4].ToString()), stand);
            }

            db.deconnecter();
        }
        public void GetAllEquipement()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM equipement";
            SqlDataReader reader = db.excecSQLRead(req);

            this.lesEquipement.Clear();

            while (reader.Read())
            {
                Equipement equip = new Equipement(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                this.lesEquipement.Add(Int32.Parse(reader[0].ToString()), equip);
            }

            db.deconnecter();
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
                Partenaire part = new Partenaire(Int32.Parse(reader[0].ToString()), reader[1].ToString(), Int32.Parse(reader[2].ToString()));
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

            Dictionary<Int32, TypePartenaire> lesTypes = new Dictionary<Int32, TypePartenaire>();
            lesTypeParNom.Clear();
            
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

            if (name != "")
            {
                if (!DoesPartenaireAlreadyExistByName(name))
                {
                    DAOFactory db = new DAOFactory();
                    db.connecter();
                    string req = "INSERT INTO partenaire VALUES ('" + id +"', '" + name +"')";
                    db.execSQLWrite(req);
            
                    MessageBox.Show("name: " + name + "\nType: " + selectedTypeLabel.ToString() + "\nAjouté !");
                    LoadCreationPartenaireData();
                }
                else
                {
                    MessageBox.Show("Le partenaire éxiste déja!"); 
                }  
            }
            else
            {
                MessageBox.Show("Le nom est vide"); 
            }
            
        }

        private void BtnAffect_Click(object sender, EventArgs e)
        {
            if (ComboAffectStand.SelectedIndex != -1)
            {
                if (ComboAffectPartenaire.SelectedIndex != -1)
                {
                    var standId = ComboAffectStand.SelectedItem.ToString();
                    var partenaireId = GetPartenaireIdByLabel(ComboAffectPartenaire.SelectedItem.ToString());

                    DAOFactory db = new DAOFactory();
                    db.connecter();
                    string req = "UPDATE stand SET idPartenaire = '" + partenaireId + "' WHERE id = '" + standId + "'";
                    db.execSQLWrite(req);
                    MessageBox.Show("Stand attribué");
                    LoadCreationPartenaireData();
                }
                else
                {
                    MessageBox.Show("Aucun Partenaire selectionné");
                }

            }
            else
            {
                MessageBox.Show("Aucun stands selectionné");
            }

        }
    }
}