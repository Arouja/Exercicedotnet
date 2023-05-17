using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Voiture : Automobile
    {
        private string couleur { get; set; }

        private string marque { get; set; }

        private string typeV { get; set; }

        //Constructeur
        public Voiture(string couleur, string marque, string typeV, int annee, string immat)
        {
            this.couleur = couleur;
            this.marque = marque;
            this.typeV = typeV;
        }
        //toString
        public override string ToString()
        {
            return "immatricule" + Immatriculation + "Annee" + Annee;
        }
    }
}
