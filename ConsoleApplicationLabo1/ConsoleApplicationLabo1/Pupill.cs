using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        //private List<Activity> lstActivities;
        //public char[] pupilEvaluations { get; set; }


        public int Grade { get; set; }
        
        public Dictionary<String,char> PupilActivities { get; set; }

       /* internal List<Activity> LstActivities
        {
            get
            {
                return lstActivities;
            }

            set
            {
                lstActivities = value;
            }
        }*/

        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            //LstActivities = new List<Activity>();
            //pupilEvaluations = new char[10];
            PupilActivities = new Dictionary<String, char>();
        }
        public Pupil(String name, int age) : this(name, age,1)
        {

            //LstActivities = new List<Activity>();
            //pupilEvaluations = new char[10];
            PupilActivities = new Dictionary<String, char>();
        }
        public void AddActivity(String activity)
        {
            //LstActivities.Add(activity);
            PupilActivities.Add(activity,'0');
        }
        public override string ToString()
        {
            string ch = Header();
            ch = PrintActivities(ch);
            return ch;
        }
        private String Header()
        {
            return base.ToString();
        }

        private string PrintActivities(String ch)
        {
            
            /*int cptActivities = LstActivities.Count();
            
            if (cptActivities == 0)
            {
                ch += "n'a pas encore choisi d'activité\n";
            }
            else
            {
                ch += "a choisi les activités suivantes:";
                foreach (Activity activity in LstActivities)
                {
                    ch += activity;
                    if (pupilEvaluations[i] != '\0')
                    {
                        ch += " a obtenu le grade : " + pupilEvaluations[i];
                    }
                    ch += "\n";

                    i++;
                }
            }
            */
            int cptActivities = PupilActivities.Count();
            if(cptActivities == 0)
            {
                ch += "n'a pas encore choisi d'activité\n";
            }
            else
            {
                ch += "a choisi les activités suivantes:";
                for(int i = 0;i > cptActivities;i++)
                {
                    ch += PupilActivities.ElementAt(i).Key.ToString() + " : " + PupilActivities.ElementAt(i).Value + "\n"; 
                }
            }
            return ch;
        }

        public void AddEvaluation(String title = null, char evaluation= 'S')
        {
            
            if(title != null)
            {
                /* while (!LstActivities[i].Title.Equals(title))
                 {
                     i++;
                 }
                 pupilEvaluations[i] = evaluation;*/
                //PupilActivities.Add(title, evaluation);
                PupilActivities[title] = evaluation;
            }
                               
        } 
    }
}
