using System;
using System.Collections.Generic;

namespace PPE_LIGUE_DAO
{
    public class Stands
    {
        private int idPartenaire;
        private string surface;
        private int nAlle;
        private int nOrdre;
        private int id;
        private List<String> equipement = new List<string>();
        public Stands(int idPartenaire, string surface, int nAlle, int nOrdre, int id)
        {
             this.idPartenaire = idPartenaire;
             this.surface = surface;
             this.nAlle = nAlle;
             this.nOrdre = nOrdre;
             this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public int GetIdPartenaire()
        {
            return this.idPartenaire;
        }

        public string GetSurface()
        {
            return this.surface;
        }

        public int GetnAlle()
        {
            return this.nAlle;
        }

        public int GetnOrdre()
        {
            return this.nOrdre;
        }

        public void AddNewEquipement(Int32 idEquipement)
        {
            this.equipement.Add(idEquipement.ToString());
        }

        public List<String> GetEquipement()
        {
            return this.equipement;
        }
        
    }
}