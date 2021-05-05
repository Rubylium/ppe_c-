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
        private Dictionary<String, Equipement> lesEquipement = new Dictionary<String, Equipement>();
        private Dictionary<Int32, Equipement> lesEquipementWithId = new Dictionary<Int32, Equipement>();
        private Dictionary<Int32, Stands> lesStands = new Dictionary<Int32, Stands>();
        private List<EquipementStands> lesEquipementDeStand = new List<EquipementStands>();
        private List<Equipement> lesFuturEquipement = new List<Equipement>();
        public main()
        {
            InitializeComponent();
            this.LoadCreationPartenaireData();
        }

        public void LoadCreationPartenaireData()
        {
            ComboEquipement.Items.Clear();
            ComboEquipementStand.Items.Clear();
            ComboEquipement.ResetText();
            ComboEquipementStand.ResetText();
            ComboTypePart.Items.Clear();
            ComboAffectPartenaire.Items.Clear();
            ComboAffectStand.Items.Clear();
            ComboAffectStand.ResetText();
            ComboAffectPartenaire.ResetText();
            DataGridViewAffect.Rows.Clear();
            lesEquipementDeStand.Clear();

            
            GetAllPartenaire();
            GetAllTypePartenaire();
            GetAllEquipement();
            GetAllStands();
            GetAllEquipementStand();
            
            foreach (var v in this.lesEquipement)
            {
                ComboEquipement.Items.Add(v.Value.GetLabel());
            }
            
            
            foreach (var v in this.lesType)
            {
                ComboTypePart.Items.Add(v.Value.GetLabel());
            }
            foreach (var v in this.lesPartenaires)
            {
                ComboAffectPartenaire.Items.Add(v.GetLabel());
            }
            
            foreach (var v in this.lesEquipementDeStand)
            {
                if (this.lesStands.ContainsKey(v.GetIdStand()))
                {
                    var stand = this.lesStands[v.GetIdStand()];
                    stand.AddNewEquipement(v.GetIdEquipement());
                    //MessageBox.Show("Equipement ajouté pour " + stand.GetId() + " equipement: " + v.GetIdEquipement());    
                }

            }

            foreach (var v in this.lesStands)
            {
                ComboAffectStand.Items.Add(v.Value.GetId());
                DataGridViewAffect.Rows.Add(v.Value.GetId(), v.Value.GetnAlle(), v.Value.GetnOrdre(), v.Value.GetSurface(), GetPartenaireLabelById(v.Value.GetIdPartenaire()));
                ComboListStandes.Items.Add(v.Value.GetId());
            }

            
        }

        public int GetMaxStandId()
        {
            var id = 0;
            foreach (var v in this.lesStands)
            {
                if (v.Value.GetId() > id)
                {
                    id = v.Value.GetId();
                }
            }

            return id;
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
        
        public void GetAllEquipementStand()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM equipementStand";
            SqlDataReader reader = db.excecSQLRead(req);

            this.lesEquipementDeStand.Clear();

            while (reader.Read())
            {
                EquipementStands equipement = new EquipementStands(Int32.Parse(reader[2].ToString()), Int32.Parse(reader[0].ToString()), Int32.Parse(reader[1].ToString()));
                this.lesEquipementDeStand.Add(equipement);
            }

            db.deconnecter();
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
                this.lesEquipement.Add(reader[1].ToString(), equip);
                this.lesEquipementWithId.Add(Int32.Parse(reader[0].ToString()), equip);
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

        private void BtnAJouterEquipement_Click(object sender, EventArgs e)
        {
            var label = ComboEquipement.SelectedItem.ToString();
            var equipement = this.lesEquipement[label];
            
            this.lesFuturEquipement.Add(equipement);
            ComboEquipementStand.Items.Clear();

            foreach (var v in this.lesFuturEquipement)
            {
                ComboEquipementStand.Items.Add(v.GetLabel());
            }
        }

        private void BtnRetirerEquipement_Click(object sender, EventArgs e)
        {
            
            var label = ComboEquipementStand.SelectedItem.ToString();
            MessageBox.Show(label);
            foreach (var v in this.lesFuturEquipement)
            {
                if (v.GetLabel() == label)
                {
                    this.lesFuturEquipement.Remove(v);
                }
                
            }
            
            ComboEquipementStand.Items.Clear();
            foreach (var v in this.lesFuturEquipement)
            {
                ComboEquipementStand.Items.Add(v.GetLabel());
            }
        }

        private void BtnAjouterStand_Click(object sender, EventArgs e)
        {
            var surface = TxtBoxSurface.Text;
            var alle = TxtBoxAlle.Text;
            var ordre = TxtBoxOrdre.Text;

            var equip = "";
            foreach (var v in this.lesFuturEquipement)
            {
                equip = equip + "\n" + v.GetLabel();
            }
            
            
            MessageBox.Show("Surface: " + surface + "\nAllée: " + alle + "\nOrdre: " + ordre + "\n" + equip);

            
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "INSERT INTO stand VALUES ('0', '" + surface +"', '" + alle +"', '" + ordre + "')";
            db.execSQLWrite(req);
            db.deconnecter();
            
            GetAllStands();
            var idStand = GetMaxStandId();

            MessageBox.Show("idStand: " + idStand);

            if (idStand != 0)
            {
                foreach (var v in this.lesFuturEquipement)
                {
                    string reqEquip = "INSERT INTO equipementStand VALUES ('" + idStand +"', '" + v.GetId() +"')";
                    db.connecter();
                    db.execSQLWrite(reqEquip);
                    db.deconnecter();
                }
            
                MessageBox.Show("Stand ajouté"); 
            }
            else
            {
                MessageBox.Show("Erreur de récupération de l'id du stands");   
            }

            LoadCreationPartenaireData();
        }

        private void ComboListStandes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ComboListStandes.SelectedItem.ToString();
            var equipement = "TEST-";
            foreach (var v in this.lesEquipementDeStand)
            {
                if (v.GetIdStand().ToString() == index)
                {
                    MessageBox.Show(v.GetIdEquipement().ToString()); 
                    //if (lesEquipementWithId.ContainsKey(v.GetIdEquipement()))
                    //{
                        equipement = equipement + "\n" + lesEquipementWithId[v.GetIdEquipement()].GetLabel(); 
                    //}
                    
                }
            }

            LblEquipement.Text = equipement;
        }
    }
}