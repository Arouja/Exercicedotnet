using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Automobile
    {
        private int annee;

        public int Annee { get => annee; set => annee = value; }

        public string Immatriculation { get => immat; set => immat = value; }

        private string immat;

        public Automobile(int annee, string immat)
        {
            this.annee = annee;
            this.immat = immat;
        }
        //ou bien on utilise 
        // string immat {set , get}

        public override string ToString()
        {

            return "immatricule" + Immatriculation + " Annee" + annee;
        }
    }
}
