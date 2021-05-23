namespace PPE_LIGUE_DAO
{
    public class Partenaire
    {
        private int id;
        private string label;
        private int idPartenaire;
        public Partenaire(int id, string label, int IdPartenaire)
        {
            this.id = id;
            this.label = label;
            this.idPartenaire = IdPartenaire;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetLabel()
        {
            return this.label;
        }

        public int GetIdPartenaire()
        {
            return this.idPartenaire;
        }
    }
}