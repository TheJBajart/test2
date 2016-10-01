using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class ContactCar
    {
        public Person Perso { get; set; }
        public Car CarPerso { get; set; }
        public ContactCar(Person perso,Car car)
        {
            Perso = perso;
            CarPerso = car;
        }
        public void DynamicPrint(dynamic objet)
        {
            System.Console.WriteLine(objet.Print() + " voiture : " + CarPerso.ToString());
        }
    }
}
