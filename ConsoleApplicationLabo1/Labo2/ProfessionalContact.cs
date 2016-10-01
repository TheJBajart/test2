using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public class ProfessionalContact : Person
    {
        public String Profession { get; set; }
        public String Tel { get; set; }
        public String Mail { get; set; }
        public List<Entreprise> LstEntreprise { get; set; }
        public ProfessionalContact(String name, String lastName,String profession, String telPro, String mailPro) : base(name, lastName)
        {
            Name = name;
            LastName = lastName;
            Profession = profession;
            Tel = telPro;
            Mail = mailPro;
            LstEntreprise = new List<Entreprise>();
        }
        public override string ToString()
        {
                return base.ToString() + " num Tel pro : " + Tel +"\nProfession : " + Profession +"\nmail pro : " + Mail+"\n\n";
        }
        public override bool HasHisBirthday()
        {
            return false;
        }
        public void EnterpriseAdd(Entreprise e)
        {
            LstEntreprise.Add(e);
        }
        public String Print()
        {
            return base.ToString() + "est un contact professionnel";
        }
    }
}
