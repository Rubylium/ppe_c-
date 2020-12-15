using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PPE_LIGUE_DAO
{
    class DAOFactory
    {
        SqlConnection connexion;

        public DAOFactory()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "MSI\\SQLEXPRESS";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "ligue";
            Console.WriteLine("Connexion info created : " + builder.ConnectionString);
            connexion = new SqlConnection(builder.ConnectionString);
        }

        public void connecter()
        {
            connexion.Open();
        }

        public void deconnecter()
        {
            connexion.Close();
        }

        // Exécution d'une requête de lecture ; retourne un Datareader
        public SqlDataReader excecSQLRead(string requete)
        {
            SqlCommand maCommand;
            SqlDataAdapter monDataAdapter;
            maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = connexion;

            monDataAdapter = new SqlDataAdapter();
            monDataAdapter.SelectCommand = maCommand;

            SqlDataReader monDR;
            monDR = maCommand.ExecuteReader();

            return monDR;
        }

        // Exécution d'une requete d'écriture (Insert ou Update) ; ne retourne rien
        public void execSQLWrite(string requete)
        {
            
            SqlCommand maCommand;
            maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = connexion;

            maCommand.ExecuteNonQuery();

        }
    }
}