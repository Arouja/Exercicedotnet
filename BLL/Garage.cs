using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Garage : Igarage
    {
        public List<Automobile> Autos = new Automobile();
        public Garage(string adresse)
        {

        }

        public string AddAuto(Automobile au)
        {
            try
            {
                Autos.Add(au);
            }

            catch(Exception ex)
            {
                return ex.Message;
            }
            //throw new NotImplementedException();
        }

        public List<Automobile> AfficherAutomobiles(SubType soustype)
        {
            throw new NotImplementedException();
        }

        public string DeleteAuto(string immatriculation)
        {
            throw new NotImplementedException();
        }

        public Automobile GetAuto(string immatriculation)
        {
            throw new NotImplementedException();
        }

        public int GetIndexAuto(Automobile ai)
        {
            throw new NotImplementedException();
        }

        public string UpdateAuto(Automobile au)
        {
            throw new NotImplementedException();
        }
    }
}
