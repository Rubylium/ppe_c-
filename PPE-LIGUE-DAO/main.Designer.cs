using System.ComponentModel;

namespace PPE_LIGUE_DAO
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.créationPartenaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationStandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectationDesStandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreateStand = new System.Windows.Forms.TabPage();
            this.BtnAjouterStand = new System.Windows.Forms.Button();
            this.BtnRetirerEquipement = new System.Windows.Forms.Button();
            this.BtnAJouterEquipement = new System.Windows.Forms.Button();
            this.ComboEquipementStand = new System.Windows.Forms.ComboBox();
            this.ComboEquipement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxOrdre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxAlle = new System.Windows.Forms.TextBox();
            this.LblSurface = new System.Windows.Forms.Label();
            this.TxtBoxSurface = new System.Windows.Forms.TextBox();
            this.tabCreatePartenaire = new System.Windows.Forms.TabPage();
            this.LabelCreationPartenaireType = new System.Windows.Forms.Label();
            this.ComboTypePart = new System.Windows.Forms.ComboBox();
            this.BtnCreationPartenaire = new System.Windows.Forms.Button();
            this.LabelCreationPartenaire = new System.Windows.Forms.Label();
            this.TxtBoxCreatePartName = new System.Windows.Forms.TextBox();
            this.tabAffectStand = new System.Windows.Forms.TabPage();
            this.BtnAffect = new System.Windows.Forms.Button();
            this.DataGridViewAffect = new System.Windows.Forms.DataGridView();
            this.idStand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboAffectPartenaire = new System.Windows.Forms.ComboBox();
            this.LabelAffectStandList = new System.Windows.Forms.Label();
            this.ComboAffectStand = new System.Windows.Forms.ComboBox();
            this.tabListStands = new System.Windows.Forms.TabPage();
            this.LblListOrdre = new System.Windows.Forms.Label();
            this.LblListAlle = new System.Windows.Forms.Label();
            this.LblListSurface = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblEquipement = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboListStandes = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabCreateStand.SuspendLayout();
            this.tabCreatePartenaire.SuspendLayout();
            this.tabAffectStand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DataGridViewAffect)).BeginInit();
            this.tabListStands.SuspendLayout();
            this.SuspendLayout();
            // 
            // créationPartenaireToolStripMenuItem
            // 
            this.créationPartenaireToolStripMenuItem.Name = "créationPartenaireToolStripMenuItem";
            this.créationPartenaireToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.créationPartenaireToolStripMenuItem.Text = "Création partenaire";
            // 
            // créationStandsToolStripMenuItem
            // 
            this.créationStandsToolStripMenuItem.Name = "créationStandsToolStripMenuItem";
            this.créationStandsToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.créationStandsToolStripMenuItem.Text = "Création stands";
            // 
            // affectationDesStandsToolStripMenuItem
            // 
            this.affectationDesStandsToolStripMenuItem.Name = "affectationDesStandsToolStripMenuItem";
            this.affectationDesStandsToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.affectationDesStandsToolStripMenuItem.Text = "Affectation des stands";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCreateStand);
            this.tabControl1.Controls.Add(this.tabCreatePartenaire);
            this.tabControl1.Controls.Add(this.tabAffectStand);
            this.tabControl1.Controls.Add(this.tabListStands);
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCreateStand
            // 
            this.tabCreateStand.Controls.Add(this.BtnAjouterStand);
            this.tabCreateStand.Controls.Add(this.BtnRetirerEquipement);
            this.tabCreateStand.Controls.Add(this.BtnAJouterEquipement);
            this.tabCreateStand.Controls.Add(this.ComboEquipementStand);
            this.tabCreateStand.Controls.Add(this.ComboEquipement);
            this.tabCreateStand.Controls.Add(this.label5);
            this.tabCreateStand.Controls.Add(this.label4);
            this.tabCreateStand.Controls.Add(this.label3);
            this.tabCreateStand.Controls.Add(this.TxtBoxOrdre);
            this.tabCreateStand.Controls.Add(this.label2);
            this.tabCreateStand.Controls.Add(this.TxtBoxAlle);
            this.tabCreateStand.Controls.Add(this.LblSurface);
            this.tabCreateStand.Controls.Add(this.TxtBoxSurface);
            this.tabCreateStand.Location = new System.Drawing.Point(4, 22);
            this.tabCreateStand.Margin = new System.Windows.Forms.Padding(2);
            this.tabCreateStand.Name = "tabCreateStand";
            this.tabCreateStand.Size = new System.Drawing.Size(776, 386);
            this.tabCreateStand.TabIndex = 0;
            this.tabCreateStand.Text = "Création stands";
            this.tabCreateStand.UseVisualStyleBackColor = true;
            // 
            // BtnAjouterStand
            // 
            this.BtnAjouterStand.Location = new System.Drawing.Point(149, 219);
            this.BtnAjouterStand.Name = "BtnAjouterStand";
            this.BtnAjouterStand.Size = new System.Drawing.Size(281, 69);
            this.BtnAjouterStand.TabIndex = 12;
            this.BtnAjouterStand.Text = "Ajouter";
            this.BtnAjouterStand.UseVisualStyleBackColor = true;
            this.BtnAjouterStand.Click += new System.EventHandler(this.BtnAjouterStand_Click);
            // 
            // BtnRetirerEquipement
            // 
            this.BtnRetirerEquipement.Location = new System.Drawing.Point(465, 152);
            this.BtnRetirerEquipement.Name = "BtnRetirerEquipement";
            this.BtnRetirerEquipement.Size = new System.Drawing.Size(85, 21);
            this.BtnRetirerEquipement.TabIndex = 11;
            this.BtnRetirerEquipement.Text = "Retirer";
            this.BtnRetirerEquipement.UseVisualStyleBackColor = true;
            this.BtnRetirerEquipement.Click += new System.EventHandler(this.BtnRetirerEquipement_Click);
            // 
            // BtnAJouterEquipement
            // 
            this.BtnAJouterEquipement.Location = new System.Drawing.Point(465, 78);
            this.BtnAJouterEquipement.Name = "BtnAJouterEquipement";
            this.BtnAJouterEquipement.Size = new System.Drawing.Size(85, 21);
            this.BtnAJouterEquipement.TabIndex = 10;
            this.BtnAJouterEquipement.Text = "Ajouter";
            this.BtnAJouterEquipement.UseVisualStyleBackColor = true;
            this.BtnAJouterEquipement.Click += new System.EventHandler(this.BtnAJouterEquipement_Click);
            // 
            // ComboEquipementStand
            // 
            this.ComboEquipementStand.FormattingEnabled = true;
            this.ComboEquipementStand.Location = new System.Drawing.Point(318, 153);
            this.ComboEquipementStand.Name = "ComboEquipementStand";
            this.ComboEquipementStand.Size = new System.Drawing.Size(127, 21);
            this.ComboEquipementStand.TabIndex = 9;
            // 
            // ComboEquipement
            // 
            this.ComboEquipement.FormattingEnabled = true;
            this.ComboEquipement.Location = new System.Drawing.Point(318, 78);
            this.ComboEquipement.Name = "ComboEquipement";
            this.ComboEquipement.Size = new System.Drawing.Size(127, 21);
            this.ComboEquipement.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(149, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stand";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(318, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Equipement";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(53, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numéro d\'ordre";
            // 
            // TxtBoxOrdre
            // 
            this.TxtBoxOrdre.Location = new System.Drawing.Point(142, 153);
            this.TxtBoxOrdre.Name = "TxtBoxOrdre";
            this.TxtBoxOrdre.Size = new System.Drawing.Size(101, 20);
            this.TxtBoxOrdre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numéro d\'allée";
            // 
            // TxtBoxAlle
            // 
            this.TxtBoxAlle.Location = new System.Drawing.Point(142, 115);
            this.TxtBoxAlle.Name = "TxtBoxAlle";
            this.TxtBoxAlle.Size = new System.Drawing.Size(101, 20);
            this.TxtBoxAlle.TabIndex = 2;
            // 
            // LblSurface
            // 
            this.LblSurface.Location = new System.Drawing.Point(92, 82);
            this.LblSurface.Name = "LblSurface";
            this.LblSurface.Size = new System.Drawing.Size(44, 23);
            this.LblSurface.TabIndex = 1;
            this.LblSurface.Text = "Surface";
            // 
            // TxtBoxSurface
            // 
            this.TxtBoxSurface.Location = new System.Drawing.Point(142, 79);
            this.TxtBoxSurface.Name = "TxtBoxSurface";
            this.TxtBoxSurface.Size = new System.Drawing.Size(101, 20);
            this.TxtBoxSurface.TabIndex = 0;
            // 
            // tabCreatePartenaire
            // 
            this.tabCreatePartenaire.Controls.Add(this.LabelCreationPartenaireType);
            this.tabCreatePartenaire.Controls.Add(this.ComboTypePart);
            this.tabCreatePartenaire.Controls.Add(this.BtnCreationPartenaire);
            this.tabCreatePartenaire.Controls.Add(this.LabelCreationPartenaire);
            this.tabCreatePartenaire.Controls.Add(this.TxtBoxCreatePartName);
            this.tabCreatePartenaire.Location = new System.Drawing.Point(4, 22);
            this.tabCreatePartenaire.Margin = new System.Windows.Forms.Padding(2);
            this.tabCreatePartenaire.Name = "tabCreatePartenaire";
            this.tabCreatePartenaire.Size = new System.Drawing.Size(776, 386);
            this.tabCreatePartenaire.TabIndex = 1;
            this.tabCreatePartenaire.Text = "Création partenaire";
            this.tabCreatePartenaire.UseVisualStyleBackColor = true;
            // 
            // LabelCreationPartenaireType
            // 
            this.LabelCreationPartenaireType.Location = new System.Drawing.Point(217, 127);
            this.LabelCreationPartenaireType.Name = "LabelCreationPartenaireType";
            this.LabelCreationPartenaireType.Size = new System.Drawing.Size(100, 21);
            this.LabelCreationPartenaireType.TabIndex = 4;
            this.LabelCreationPartenaireType.Text = "Type de partenaire";
            // 
            // ComboTypePart
            // 
            this.ComboTypePart.FormattingEnabled = true;
            this.ComboTypePart.Items.AddRange(new object[] {"test, tes2"});
            this.ComboTypePart.Location = new System.Drawing.Point(323, 124);
            this.ComboTypePart.Name = "ComboTypePart";
            this.ComboTypePart.Size = new System.Drawing.Size(136, 21);
            this.ComboTypePart.TabIndex = 3;
            // 
            // BtnCreationPartenaire
            // 
            this.BtnCreationPartenaire.Location = new System.Drawing.Point(323, 201);
            this.BtnCreationPartenaire.Name = "BtnCreationPartenaire";
            this.BtnCreationPartenaire.Size = new System.Drawing.Size(136, 40);
            this.BtnCreationPartenaire.TabIndex = 2;
            this.BtnCreationPartenaire.Text = "Créer";
            this.BtnCreationPartenaire.UseVisualStyleBackColor = true;
            this.BtnCreationPartenaire.Click += new System.EventHandler(this.BtnCreationPartenaire_Click);
            // 
            // LabelCreationPartenaire
            // 
            this.LabelCreationPartenaire.Location = new System.Drawing.Point(217, 169);
            this.LabelCreationPartenaire.Name = "LabelCreationPartenaire";
            this.LabelCreationPartenaire.Size = new System.Drawing.Size(100, 20);
            this.LabelCreationPartenaire.TabIndex = 1;
            this.LabelCreationPartenaire.Text = "Nom du partenaire";
            // 
            // TxtBoxCreatePartName
            // 
            this.TxtBoxCreatePartName.Location = new System.Drawing.Point(323, 166);
            this.TxtBoxCreatePartName.Name = "TxtBoxCreatePartName";
            this.TxtBoxCreatePartName.Size = new System.Drawing.Size(136, 20);
            this.TxtBoxCreatePartName.TabIndex = 0;
            // 
            // tabAffectStand
            // 
            this.tabAffectStand.Controls.Add(this.BtnAffect);
            this.tabAffectStand.Controls.Add(this.DataGridViewAffect);
            this.tabAffectStand.Controls.Add(this.label1);
            this.tabAffectStand.Controls.Add(this.ComboAffectPartenaire);
            this.tabAffectStand.Controls.Add(this.LabelAffectStandList);
            this.tabAffectStand.Controls.Add(this.ComboAffectStand);
            this.tabAffectStand.Location = new System.Drawing.Point(4, 22);
            this.tabAffectStand.Margin = new System.Windows.Forms.Padding(2);
            this.tabAffectStand.Name = "tabAffectStand";
            this.tabAffectStand.Size = new System.Drawing.Size(776, 386);
            this.tabAffectStand.TabIndex = 2;
            this.tabAffectStand.Text = "Affectation Stands";
            this.tabAffectStand.UseVisualStyleBackColor = true;
            // 
            // BtnAffect
            // 
            this.BtnAffect.Location = new System.Drawing.Point(377, 35);
            this.BtnAffect.Name = "BtnAffect";
            this.BtnAffect.Size = new System.Drawing.Size(169, 61);
            this.BtnAffect.TabIndex = 5;
            this.BtnAffect.Text = "Affecter";
            this.BtnAffect.UseVisualStyleBackColor = true;
            this.BtnAffect.Click += new System.EventHandler(this.BtnAffect_Click);
            // 
            // DataGridViewAffect
            // 
            this.DataGridViewAffect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAffect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.idStand, this.alle, this.ordre, this.surface, this.attrib});
            this.DataGridViewAffect.Location = new System.Drawing.Point(92, 117);
            this.DataGridViewAffect.Name = "DataGridViewAffect";
            this.DataGridViewAffect.Size = new System.Drawing.Size(544, 192);
            this.DataGridViewAffect.TabIndex = 4;
            // 
            // idStand
            // 
            this.idStand.HeaderText = "Id Stand";
            this.idStand.Name = "idStand";
            // 
            // alle
            // 
            this.alle.HeaderText = "n°d’allée";
            this.alle.Name = "alle";
            // 
            // ordre
            // 
            this.ordre.HeaderText = "n°d\'ordre";
            this.ordre.Name = "ordre";
            // 
            // surface
            // 
            this.surface.HeaderText = "Surface";
            this.surface.Name = "surface";
            // 
            // attrib
            // 
            this.attrib.HeaderText = "Partenaire";
            this.attrib.Name = "attrib";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(163, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Partenaires";
            // 
            // ComboAffectPartenaire
            // 
            this.ComboAffectPartenaire.FormattingEnabled = true;
            this.ComboAffectPartenaire.Location = new System.Drawing.Point(231, 75);
            this.ComboAffectPartenaire.Name = "ComboAffectPartenaire";
            this.ComboAffectPartenaire.Size = new System.Drawing.Size(121, 21);
            this.ComboAffectPartenaire.TabIndex = 2;
            // 
            // LabelAffectStandList
            // 
            this.LabelAffectStandList.Location = new System.Drawing.Point(181, 38);
            this.LabelAffectStandList.Name = "LabelAffectStandList";
            this.LabelAffectStandList.Size = new System.Drawing.Size(44, 23);
            this.LabelAffectStandList.TabIndex = 1;
            this.LabelAffectStandList.Text = "Stands";
            // 
            // ComboAffectStand
            // 
            this.ComboAffectStand.FormattingEnabled = true;
            this.ComboAffectStand.Location = new System.Drawing.Point(231, 35);
            this.ComboAffectStand.Name = "ComboAffectStand";
            this.ComboAffectStand.Size = new System.Drawing.Size(121, 21);
            this.ComboAffectStand.TabIndex = 0;
            // 
            // tabListStands
            // 
            this.tabListStands.Controls.Add(this.LblListOrdre);
            this.tabListStands.Controls.Add(this.LblListAlle);
            this.tabListStands.Controls.Add(this.LblListSurface);
            this.tabListStands.Controls.Add(this.label9);
            this.tabListStands.Controls.Add(this.label8);
            this.tabListStands.Controls.Add(this.label7);
            this.tabListStands.Controls.Add(this.LblEquipement);
            this.tabListStands.Controls.Add(this.label6);
            this.tabListStands.Controls.Add(this.ComboListStandes);
            this.tabListStands.Location = new System.Drawing.Point(4, 22);
            this.tabListStands.Name = "tabListStands";
            this.tabListStands.Padding = new System.Windows.Forms.Padding(3);
            this.tabListStands.Size = new System.Drawing.Size(776, 386);
            this.tabListStands.TabIndex = 3;
            this.tabListStands.Text = "Liste des stands";
            this.tabListStands.UseVisualStyleBackColor = true;
            // 
            // LblListOrdre
            // 
            this.LblListOrdre.Location = new System.Drawing.Point(301, 152);
            this.LblListOrdre.Name = "LblListOrdre";
            this.LblListOrdre.Size = new System.Drawing.Size(121, 23);
            this.LblListOrdre.TabIndex = 8;
            this.LblListOrdre.Text = "Rien selectioné";
            this.LblListOrdre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblListAlle
            // 
            this.LblListAlle.Location = new System.Drawing.Point(167, 152);
            this.LblListAlle.Name = "LblListAlle";
            this.LblListAlle.Size = new System.Drawing.Size(106, 23);
            this.LblListAlle.TabIndex = 7;
            this.LblListAlle.Text = "Rien selectioné";
            this.LblListAlle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblListSurface
            // 
            this.LblListSurface.Location = new System.Drawing.Point(20, 152);
            this.LblListSurface.Name = "LblListSurface";
            this.LblListSurface.Size = new System.Drawing.Size(106, 23);
            this.LblListSurface.TabIndex = 6;
            this.LblListSurface.Text = "Rien selectioné";
            this.LblListSurface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(301, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Numéro d\'ordre";
            this.label9.UseMnemonic = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(157, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Numéro d\'allée";
            this.label8.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(41, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Surface";
            this.label7.UseMnemonic = false;
            // 
            // LblEquipement
            // 
            this.LblEquipement.Location = new System.Drawing.Point(474, 156);
            this.LblEquipement.Name = "LblEquipement";
            this.LblEquipement.Size = new System.Drawing.Size(300, 275);
            this.LblEquipement.TabIndex = 2;
            this.LblEquipement.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(474, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Equipement";
            this.label6.UseMnemonic = false;
            // 
            // ComboListStandes
            // 
            this.ComboListStandes.FormattingEnabled = true;
            this.ComboListStandes.Location = new System.Drawing.Point(41, 32);
            this.ComboListStandes.Name = "ComboListStandes";
            this.ComboListStandes.Size = new System.Drawing.Size(337, 21);
            this.ComboListStandes.TabIndex = 0;
            this.ComboListStandes.SelectedIndexChanged += new System.EventHandler(this.ComboListStandes_SelectedIndexChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 409);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "main";
            this.tabControl1.ResumeLayout(false);
            this.tabCreateStand.ResumeLayout(false);
            this.tabCreateStand.PerformLayout();
            this.tabCreatePartenaire.ResumeLayout(false);
            this.tabCreatePartenaire.PerformLayout();
            this.tabAffectStand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.DataGridViewAffect)).EndInit();
            this.tabListStands.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LblListOrdre;

        private System.Windows.Forms.Label LblListAlle;

        private System.Windows.Forms.Label LblListSurface;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label LblEquipement;

        private System.Windows.Forms.ComboBox ComboListStandes;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabListStands;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.TextBox TxtBoxOrdre;

        private System.Windows.Forms.Button BtnAjouterStand;

        private System.Windows.Forms.ComboBox ComboEquipement;
        private System.Windows.Forms.ComboBox ComboEquipementStand;
        private System.Windows.Forms.Button BtnAJouterEquipement;
        private System.Windows.Forms.Button BtnRetirerEquipement;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox TxtBoxAlle;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox TxtBoxSurface;
        private System.Windows.Forms.Label LblSurface;

        private System.Windows.Forms.Button BtnAffect;

        private System.Windows.Forms.DataGridViewTextBoxColumn alle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordre;

        private System.Windows.Forms.DataGridView DataGridViewAffect;

        private System.Windows.Forms.DataGridViewTextBoxColumn idStand;
        private System.Windows.Forms.DataGridViewTextBoxColumn surface;
        private System.Windows.Forms.DataGridViewTextBoxColumn attrib;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.ComboBox ComboAffectStand;

        private System.Windows.Forms.ComboBox ComboAffectPartenaire;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelAffectStandList;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox TxtBoxCreatePartName;

        private System.Windows.Forms.ComboBox ComboTypePart;
        
        private System.Windows.Forms.Label LabelCreationPartenaireType;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelCreationPartenaire;
        private System.Windows.Forms.Button BtnCreationPartenaire;

        private System.Windows.Forms.TabPage tabAffectStand;
        private System.Windows.Forms.TabPage tabCreatePartenaire;

        private System.Windows.Forms.TabPage tabCreateStand;

        private System.Windows.Forms.TabControl tabControl1;

        private System.Windows.Forms.ToolStripMenuItem affectationDesStandsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem créationStandsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem créationPartenaireToolStripMenuItem;

        #endregion
    }
}