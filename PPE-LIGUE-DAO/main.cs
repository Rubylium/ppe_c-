using System;
using System.Windows.Forms;

namespace PPE_LIGUE_DAO
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public void CreateStand()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "INSERT INTO stand VALUES ";

            db.execSQLWrite(req);
        }
    }
}