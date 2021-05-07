using System;
using System.Windows.Forms;

namespace PPE_LIGUE_DAO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            boxMdp.PasswordChar = '*';
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
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                MessageBox.Show("Login Réussi!");
            }
            else
            {
                MessageBox.Show("Login Invalide!");
            }
            
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // j'y est pensé ! :D
        }
    }
}