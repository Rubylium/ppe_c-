using System;
using System.Windows.Forms;

namespace PPE_LIGUE_DAO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Réussi!");
            main fm = new main();


            this.Hide();
            fm.Show();
        }
    }
}