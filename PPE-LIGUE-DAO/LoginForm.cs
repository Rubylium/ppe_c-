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
            String login = boxLogin.Text;
            String mdp = boxMdp.Text;

            bool didLogin = loginDAO.TryLogin(login, mdp);

            if (didLogin)
            {
                this.Hide();
                main fm = new main();
                fm.Show();
                MessageBox.Show("Login Réussi!");
            }
            else
            {
                MessageBox.Show("Login Invalide!");
            }
            
        }
    }
}