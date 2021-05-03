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
            this.tabCreatePartenaire = new System.Windows.Forms.TabPage();
            this.LabelCreationPartenaireType = new System.Windows.Forms.Label();
            this.ComboTypePart = new System.Windows.Forms.ComboBox();
            this.BtnCreationPartenaire = new System.Windows.Forms.Button();
            this.LabelCreationPartenaire = new System.Windows.Forms.Label();
            this.TxtBoxCreatePartName = new System.Windows.Forms.TextBox();
            this.tabAffectStand = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabCreatePartenaire.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCreateStand
            // 
            this.tabCreateStand.Location = new System.Drawing.Point(4, 22);
            this.tabCreateStand.Margin = new System.Windows.Forms.Padding(2);
            this.tabCreateStand.Name = "tabCreateStand";
            this.tabCreateStand.Size = new System.Drawing.Size(581, 329);
            this.tabCreateStand.TabIndex = 0;
            this.tabCreateStand.Text = "Création stands";
            this.tabCreateStand.UseVisualStyleBackColor = true;
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
            this.tabCreatePartenaire.Size = new System.Drawing.Size(581, 329);
            this.tabCreatePartenaire.TabIndex = 1;
            this.tabCreatePartenaire.Text = "Création partenaire";
            this.tabCreatePartenaire.UseVisualStyleBackColor = true;
            // 
            // LabelCreationPartenaireType
            // 
            this.LabelCreationPartenaireType.Location = new System.Drawing.Point(101, 90);
            this.LabelCreationPartenaireType.Name = "LabelCreationPartenaireType";
            this.LabelCreationPartenaireType.Size = new System.Drawing.Size(100, 21);
            this.LabelCreationPartenaireType.TabIndex = 4;
            this.LabelCreationPartenaireType.Text = "Type de partenaire";
            // 
            // ComboTypePart
            // 
            this.ComboTypePart.FormattingEnabled = true;
            this.ComboTypePart.Items.AddRange(new object[] {"test, tes2"});
            this.ComboTypePart.Location = new System.Drawing.Point(207, 87);
            this.ComboTypePart.Name = "ComboTypePart";
            this.ComboTypePart.Size = new System.Drawing.Size(136, 21);
            this.ComboTypePart.TabIndex = 3;
            // 
            // BtnCreationPartenaire
            // 
            this.BtnCreationPartenaire.Location = new System.Drawing.Point(207, 164);
            this.BtnCreationPartenaire.Name = "BtnCreationPartenaire";
            this.BtnCreationPartenaire.Size = new System.Drawing.Size(136, 40);
            this.BtnCreationPartenaire.TabIndex = 2;
            this.BtnCreationPartenaire.Text = "Créer";
            this.BtnCreationPartenaire.UseVisualStyleBackColor = true;
            this.BtnCreationPartenaire.Click += new System.EventHandler(this.BtnCreationPartenaire_Click);
            // 
            // LabelCreationPartenaire
            // 
            this.LabelCreationPartenaire.Location = new System.Drawing.Point(101, 132);
            this.LabelCreationPartenaire.Name = "LabelCreationPartenaire";
            this.LabelCreationPartenaire.Size = new System.Drawing.Size(100, 20);
            this.LabelCreationPartenaire.TabIndex = 1;
            this.LabelCreationPartenaire.Text = "Nom du partenaire";
            // 
            // TxtBoxCreatePartName
            // 
            this.TxtBoxCreatePartName.Location = new System.Drawing.Point(207, 129);
            this.TxtBoxCreatePartName.Name = "TxtBoxCreatePartName";
            this.TxtBoxCreatePartName.Size = new System.Drawing.Size(136, 20);
            this.TxtBoxCreatePartName.TabIndex = 0;
            // 
            // tabAffectStand
            // 
            this.tabAffectStand.Location = new System.Drawing.Point(4, 22);
            this.tabAffectStand.Margin = new System.Windows.Forms.Padding(2);
            this.tabAffectStand.Name = "tabAffectStand";
            this.tabAffectStand.Size = new System.Drawing.Size(581, 329);
            this.tabAffectStand.TabIndex = 2;
            this.tabAffectStand.Text = "Affectation Stands";
            this.tabAffectStand.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "main";
            this.tabControl1.ResumeLayout(false);
            this.tabCreatePartenaire.ResumeLayout(false);
            this.tabCreatePartenaire.PerformLayout();
            this.ResumeLayout(false);
        }

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