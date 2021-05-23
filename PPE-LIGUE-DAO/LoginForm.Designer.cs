using System.ComponentModel;

namespace PPE_LIGUE_DAO
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.boxMdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxLogin
            // 
            this.boxLogin.Location = new System.Drawing.Point(125, 48);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(100, 20);
            this.boxLogin.TabIndex = 0;
            // 
            // boxMdp
            // 
            this.boxMdp.Location = new System.Drawing.Point(125, 85);
            this.boxMdp.Name = "boxMdp";
            this.boxMdp.Size = new System.Drawing.Size(100, 20);
            this.boxMdp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Utilisateur";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mots de passe";
            // 
            // buttonConnect
            // 
            this.buttonConnect.ForeColor = System.Drawing.Color.Snow;
            this.buttonConnect.Image = ((System.Drawing.Image) (resources.GetObject("buttonConnect.Image")));
            this.buttonConnect.Location = new System.Drawing.Point(125, 141);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Se connecter";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 192);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxMdp);
            this.Controls.Add(this.boxLogin);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Authentification";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox boxLogin;
        private System.Windows.Forms.TextBox boxMdp;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}