using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class PrivateContact : Person
    {
        public String Tel { get; set; }
        public String Mail { get; set; }
        public DateTime DateAnniversaire { get; set; }
        public PrivateContact(String name, String lastName, String tel, String mail,DateTime dateAnniversaire) : base(name,lastName)
        {
            Name = name;
            LastName = lastName;
            Tel = tel;
            Mail = mail;
            DateAnniversaire = dateAnniversaire;
        }
        public PrivateContact(String name, String lastName, String tel, String mail) : base(name, lastName)
        {
            Name = name;
            LastName = lastName;
            Tel = tel;
            Mail = mail;
            
        }
        public override string ToString()
        {
            if (HasHisBirthday() == true)
            {
                return base.ToString() + "\nnum Tel privé : " + Tel + "\nmail : " + Mail + "\nBon anniversaire\n";
            }
            else
            {
                return base.ToString() + "\nnum Tel privé : " + Tel + "\nmail : " + Mail+"\n";
            }

            
        }
        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Month == DateAnniversaire.Month && DateTime.Today.Day == DateAnniversaire.Day);
        }
        public String Print()
        {
            return base.ToString() + "est un contact privé"; 
        }
    }
}
