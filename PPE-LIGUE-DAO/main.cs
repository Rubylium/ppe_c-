using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE_LIGUE_DAO
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public void GetAllPartenaire()
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "SELECT * FROM partenaire";

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                
            }

            db.deconnecter();
        }
    }
}