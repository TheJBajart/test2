using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Car
    {
        public String Plaque { get; set; }
        public Car(String plaque)
        {
            Plaque = plaque;
        }
        public override string ToString()
        {
            return "numéro de plaque : "+Plaque;
        }
    }
}
