using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodealongEmne3
{
    public abstract class Dyr
    {
        public string Navn { get; private set; }
        public string Art { get; private set; }
        public int Age { get; private set; }

        protected Dyr(string navn, string art, int age)
        {
            Navn = navn;
            Art = art;
            Age = age;
        }

        public virtual void Info()
        {
            Console.WriteLine($"{Navn}");
            Console.WriteLine($"{Art}");
            Console.WriteLine($"{Age}");
        }
    }
}
