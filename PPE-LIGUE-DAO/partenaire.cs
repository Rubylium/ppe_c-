namespace PPE_LIGUE_DAO
{
    public class Partenaire
    {
        private int id;
        private string label;
        public Partenaire(int id, string label)
        {
            this.id = id;
            this.label = label;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetLabel()
        {
            return this.label;
        }
    }
}