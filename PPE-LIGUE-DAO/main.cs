using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            lesPartenaires.Clear();
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
            lesEquipementWithId.Clear();
            lesFuturEquipement.Clear();
            ComboListStandes.Items.Clear();


            this.lesPartenaires = DAOPartenaire.GetAllPartenaire();
            
            this.lesTypeParNom.Clear();
            this.lesType = DAOTypePartenaire.GetAllTypePartenaire();
            this.lesTypeParNom = DAOTypePartenaire.GetAllTypePartenaireByName();

            this.lesEquipement.Clear();
            this.lesEquipement = DAOEquipement.GetAllEquipement();
            this.lesEquipementWithId = DAOEquipement.GetAllEquipementWithId();
            
            this.lesStands.Clear();
            this.lesStands = DAOStands.GetAllStands();

            this.lesEquipementDeStand.Clear();
            this.lesEquipementDeStand = DAOEquipementStand.GetAllEquipementStand();
            
            
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
                DataGridViewAffect.Rows.Add(v.Value.GetId(), v.Value.GetnAlle(), v.Value.GetnOrdre(), v.Value.GetSurface() + "m", GetPartenaireLabelById(v.Value.GetIdPartenaire()));
                ComboListStandes.Items.Add(v.Value.GetId());
            }
        }

        public bool IsAlreadyAdded(String label)
        {
            bool added = false;

            foreach (var v in this.lesFuturEquipement)
            {
                if (v.GetLabel() == label)
                {
                    added = true;
                    break;
                }
            }

            return added;
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

        private void BtnCreationPartenaire_Click(object sender, EventArgs e)
        {
            if (ComboTypePart.SelectedIndex != -1)
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
                        ComboTypePart.ResetText();
                        TxtBoxCreatePartName.Clear();
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
            else
            {
                MessageBox.Show("Aucune séléction"); 
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
            if (ComboEquipement.SelectedIndex != -1)
            {
                var label = ComboEquipement.SelectedItem.ToString();
                if (!IsAlreadyAdded(label))
                {
                    var equipement = this.lesEquipement[label];
            
                    this.lesFuturEquipement.Add(equipement);
                    ComboEquipementStand.Items.Clear();

                    foreach (var v in this.lesFuturEquipement)
                    {
                        ComboEquipementStand.Items.Add(v.GetLabel());
                    }
                }
                else
                {
                    MessageBox.Show("Équipement déjà ajouté"); 
                }
                
                
            }

        }

        private void BtnRetirerEquipement_Click(object sender, EventArgs e)
        {
            if (ComboEquipementStand.SelectedIndex != -1)
            {
                var label = ComboEquipementStand.SelectedItem.ToString();
                //MessageBox.Show(label);
                Equipement equipementToRemove = new Equipement(1, "dump");
                foreach (var v in this.lesFuturEquipement)
                {
                    if (v.GetLabel() == label)
                    {
                        equipementToRemove = v;
                        //this.lesFuturEquipement.Remove(v);
                    }
                
                }

                this.lesFuturEquipement.Remove(equipementToRemove);
            
                ComboEquipementStand.ResetText();
                ComboEquipementStand.Items.Clear();
                foreach (var v in this.lesFuturEquipement)
                {
                    ComboEquipementStand.Items.Add(v.GetLabel());
                }   
            }

        }

        private void BtnAjouterStand_Click(object sender, EventArgs e)
        {
            var surface = TxtBoxSurface.Text;
            var alle = TxtBoxAlle.Text;
            var ordre = TxtBoxOrdre.Text;

            if (surface == "")
            {
                MessageBox.Show("La surface entrée est incorrecte, seul un nombre est accepté");
                return;
            }
            
            if (alle == "")
            {
                MessageBox.Show("Le numéro d'allée est incorrecte, seul un nombre est accepté");
                return;
            }
            
            if (ordre == "")
            {
                MessageBox.Show("Le numéro d'ordre est incorrecte, seul un nombre est accepté");
                return;
            }

            if (!surface.All(char.IsDigit))
            {
                MessageBox.Show("La surface entrée est incorrecte, seul un nombre est accepté");
                return;
            }
            
            if (!alle.All(char.IsDigit))
            {
                MessageBox.Show("Le numéro d'allée est incorrecte, seul un nombre est accepté");
                return;
            }
            
            if (!ordre.All(char.IsDigit))
            {
                MessageBox.Show("Le numéro d'ordre est incorrecte, seul un nombre est accepté");
                return;
            }

            var equip = "";
            foreach (var v in this.lesFuturEquipement)
            {
                equip = equip + "\n" + v.GetLabel();
            }
            
            
            //MessageBox.Show("Surface: " + surface + "\nAllée: " + alle + "\nOrdre: " + ordre + "\n" + equip);

            
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "INSERT INTO stand VALUES ('0', '" + surface +"', '" + alle +"', '" + ordre + "')";
            db.execSQLWrite(req);
            db.deconnecter();
            
            this.lesStands.Clear();
            this.lesStands = DAOStands.GetAllStands();
            var idStand = GetMaxStandId();

            //MessageBox.Show("idStand: " + idStand);

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
            var equipement = "";
            foreach (var v in this.lesEquipementDeStand)
            {
                if (v.GetIdStand().ToString() == index)
                {
                    if (lesEquipementWithId.ContainsKey(v.GetIdEquipement())) // To avoid crash if equipement is deleted later but for some reason still loaded
                    {
                        equipement = equipement + "\n- " + lesEquipementWithId[v.GetIdEquipement()].GetLabel(); 
                    }
                    
                }
            }
            LblEquipement.Text = equipement;

            if (this.lesStands.ContainsKey(Int32.Parse(index)))
            {
                var stand = this.lesStands[Int32.Parse(index)];
                LblListSurface.Text = stand.GetSurface() + "m";
                LblListAlle.Text = stand.GetnAlle().ToString();
                LblListOrdre.Text = stand.GetnOrdre().ToString();
            }
        }


        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye");   
            Application.Exit();  // j'y est pensé ! :D
        }
    }
}