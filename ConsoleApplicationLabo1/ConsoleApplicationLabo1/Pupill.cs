using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        public int Grade { get; set; }
        private List<Activity> lstActivities;
        public char[] TabEval { get; set; }

        internal List<Activity> LstActivities
        {
            get
            {
                return lstActivities;
            }

            set
            {
                lstActivities = value;
            }
        }

        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
         }
        public Pupil(String name, int age) : this(name, age,1)
        {
            
            LstActivities = new List<Activity>();
            TabEval = new char[10];

        }
        public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }
        public override string ToString()
        {
            string ch = base.ToString();
            int i = 0;
            int cptActivities = LstActivities.Count();
            if (cptActivities == 0)
            {
                ch += "n'a pas encore choisi d'activité";
            }
            else
            {
                ch += "a choisi les activités suivantes:";
                foreach(Activity activity in LstActivities)
                {
                    ch += activity;
                    if(TabEval[i] != '\0')
                    {
                        ch += " a obtenu le grade : " + TabEval[i];
                    }
                    ch += "\n";
                    
                    i++;
                }
            }
            return ch;
        }
        public void AddEvaluation(String title = null, char evaluation= 'S')
        {
            int i = 0;
            if(title != null)
            {
                while (!LstActivities[i].Title.Equals(title))
                {
                    i++;
                }
                TabEval[i] = evaluation;
            }
                               
        } 
    }
}
