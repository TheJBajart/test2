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
            julien.AddActivity(cours1);
            julien.AddActivity(cours2);
            julien.AddActivity(cours3);
            julien.AddActivity(cours4);
            julien.AddEvaluation("math");
            julien.AddEvaluation("francais",'T');
            System.Console.Write(julien);
            System.Console.Read();
        }
    }
}
