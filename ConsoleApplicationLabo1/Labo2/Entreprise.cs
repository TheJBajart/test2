using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public class Entreprise
    {
        public String Name { get; set; }
        public String Locality{ get; set; }
        public override string ToString()
        {
            return "L'entreprise " + Name + " se trouve à " + Locality;
        }
        public Entreprise(String name,String locality)
        {
            Name = name;
            Locality = locality;
        }
    }
}
