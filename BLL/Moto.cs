using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Moto:Automobile
    {
        private int cylindre { get; set; }
        private float vitesseMax { get; set; }


        public Moto(int cylindre, float vitesseMax, int annee, string immat) : base(annee, immat) // base pour fair appel au const du la classe mere
        {
            this.cylindre = cylindre;
            this.vitesseMax = vitesseMax;
        }

        public override string ToString()
        {
            return base.ToString() + "cylindre" + cylindre + " vitesseMax" + vitesseMax;
        }
    }
}
