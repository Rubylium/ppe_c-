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
            this.tabAffectStand = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCreateStand
            // 
            this.tabCreateStand.Location = new System.Drawing.Point(4, 25);
            this.tabCreateStand.Name = "tabCreateStand";
            this.tabCreateStand.Size = new System.Drawing.Size(777, 408);
            this.tabCreateStand.TabIndex = 0;
            this.tabCreateStand.Text = "Création stands";
            this.tabCreateStand.UseVisualStyleBackColor = true;
            // 
            // tabCreatePartenaire
            // 
            this.tabCreatePartenaire.Location = new System.Drawing.Point(4, 25);
            this.tabCreatePartenaire.Name = "tabCreatePartenaire";
            this.tabCreatePartenaire.Size = new System.Drawing.Size(777, 408);
            this.tabCreatePartenaire.TabIndex = 1;
            this.tabCreatePartenaire.Text = "Création partenaire";
            this.tabCreatePartenaire.UseVisualStyleBackColor = true;
            // 
            // tabAffectStand
            // 
            this.tabAffectStand.Location = new System.Drawing.Point(4, 25);
            this.tabAffectStand.Name = "tabAffectStand";
            this.tabAffectStand.Size = new System.Drawing.Size(777, 408);
            this.tabAffectStand.TabIndex = 2;
            this.tabAffectStand.Text = "Affectation Stands";
            this.tabAffectStand.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "main";
            this.Text = "main";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

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