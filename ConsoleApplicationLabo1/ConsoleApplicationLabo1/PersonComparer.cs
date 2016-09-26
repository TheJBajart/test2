using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public Boolean Equals(Person a,Person b)
        {
            return (a.Age == b.Age & a.Name.Equals(b.Name));
        }
        public int GetHashCode(Person a)
        {
            return (int)Math.Pow(a.Name.GetHashCode(), a.Age);
        } 
    }
}
