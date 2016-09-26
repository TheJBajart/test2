using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil julien = new Pupil("julien", 10);
            Activity cours1 = new Activity("math", true);
            Activity cours2 = new Activity("francais", true);
            Activity cours3 = new Activity("Gym", true);
            Activity cours4 = new Activity("dessin", false);
            julien.AddActivity("math");
            julien.AddEvaluation("math");
            julien.AddEvaluation("francais",'T');
            System.Console.Write(julien);
            Pupil etu2 = new Pupil("ju", 10);
            Pupil etu3 = new Pupil("julie", 6);
            Pupil etu4 = new Pupil("julienne", 4,1);
            Pupil etu5 = new Pupil("jules", 10);
            List<Pupil> lstPupill = new List<Pupil>()
            {
                new Pupil("ju", 10),
                new Pupil("jul", 10),
                new Pupil("jules", 10),
            };
            List<Person> lstPerson = new List<Person>()
            {
                new Person("vincent", 7),
                new Person("clem", 8),
                new Person("ok", 10),
            };
            lstPupill.Add(julien);
            var listFusion = lstPerson.Union(lstPupill);
            foreach(var fusion in listFusion)
            {
                System.Console.Write(fusion.Name+"\n");
            }
            System.Console.Read();
            System.Console.Read();
            System.Console.Clear();
            /*var pupilGrade1Plus6 = lstPupill.Where(Pupil => Pupil.Age > 6 && Pupil.Grade == 1);
            if (pupilGrade1Plus6 != null)
                foreach (var pupill in pupilGrade1Plus6)
                {
                    System.Console.Write(pupill);
                }*/
            List<Pupil> lstPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("ju", 10),
                new Pupil("ju", 10),
                new Pupil("ju", 10),
            };
            IEnumerable<Pupil> lstPupilsNoDuplicated = lstPupilsDuplicated.Distinct<Pupil>(new PersonComparer());
            foreach (var fusion in lstPupilsNoDuplicated)
            {
                System.Console.Write(fusion.Name + "\n");
            }
            System.Console.Read();
        }
    }
}
