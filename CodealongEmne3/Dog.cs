using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodealongEmne3
{
    internal class Dog : Dyr
    {
        public string Owner { get; private set; }
        public Dog(string navn, string art, int age) : base(navn, art, age)
        {
            //Owner = owner;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"{Owner}");
        }
    }
}
