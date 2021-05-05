namespace PPE_LIGUE_DAO
{
    public class EquipementStands
    {
        private int id;
        private int idStand;
        private int idEquipement;
        public EquipementStands(int id, int idStand, int idEquipement)
        {
            this.id = id;
            this.idStand = idStand;
            this.idEquipement = idEquipement;
        }

        public int GetId()
        {
            return this.id;
        }

        public int GetIdStand()
        {
            return this.idStand;
        }

        public int GetIdEquipement()
        {
            return this.idEquipement;
        }

    }
}