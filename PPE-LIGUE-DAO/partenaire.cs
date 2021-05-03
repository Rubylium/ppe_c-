namespace PPE_LIGUE_DAO
{
    public class partenaire
    {
        private int id;
        private string label;
        public partenaire(int id, string label)
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