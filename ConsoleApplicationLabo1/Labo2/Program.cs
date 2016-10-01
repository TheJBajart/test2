using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrivateContact p1 = new PrivateContact("Strange", "Hugo", "0470/45.25.95", "Hugo-Strange@Gotham.saison2");
            PrivateContact p2 = new PrivateContact("Wayne", "Bruce", "0470/45.47.42", "Bruce-Wayne@Gotham.saison1", new DateTime(1985, 9, 27));
            System.Console.Write(new DateTime(1985,3,1)+"\n");
            System.Console.Write(p1);
            System.Console.Write(p2);
            System.Console.Read();
            System.Console.Read();
            System.Console.Clear();
            ProfessionalContact pro1 = new ProfessionalContact("dupont", "louis", "consultant", "0470/47.25.65", "Hugo-Strange@Gotham.saison2");
            ProfessionalContact pro2 = new ProfessionalContact("dupont", "louisa", "consultant", "0470/47.25.65", "Hugo-Strange@Gotham.saison2");
            ProfessionalContact pro3 = new ProfessionalContact("dupont", "lou", "indépendant", "0470/47.25.65", "Hugo-Strange@Gotham.saison2");
            System.Console.Write(pro1);
            System.Console.Write(pro2);
            System.Console.Write(pro3);
            System.Console.Read();
            System.Console.Read();
            System.Console.Clear();
            Entreprise e1 = new Entreprise("Civadis", "Namur");
            Entreprise e2 = new Entreprise("Belfius", "Namur");
            pro1.EnterpriseAdd(e1);
            pro1.EnterpriseAdd(e2);
            pro2.EnterpriseAdd(e2);
            List<ProfessionalContact> lstPro = new List<ProfessionalContact>();
            lstPro.Add(pro1);
            lstPro.Add(pro2);
            lstPro.Add(pro3);
            var lstIndependant = lstPro.Where(ProfessionalContact => ProfessionalContact.Profession.Equals("indépendant"));
            System.Console.Write("nombre d'indépendant : " + lstIndependant.Count());
            var lstConsultant = lstPro.Where(ProfessionalContact => ProfessionalContact.Profession.Equals("consultant") && ProfessionalContact.LstEntreprise.Equals("Civadis"));
            System.Console.Write(lstConsultant.Count());
            System.Console.Read();
            System.Console.Read();
            System.Console.Clear();
            Car car1 = new Car("154bf");
            ContactCar contact1 = new ContactCar(p1, car1);
            contact1.DynamicPrint(p1);
            Car car2 = new Car("157bf");
            ContactCar contact2 = new ContactCar(pro1, car2);
            contact2.DynamicPrint(pro1);
            System.Console.Read();
            System.Console.Read();
            System.Console.Clear();
        }
    }
}
