using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Kangaroo : Animal
    {
        public Kangaroo(string type, string name, Colors color, int age) : base(type, name, color, age)
        {
        }

        public override void SpecialAction()
        {
            Console.WriteLine("*the kangaroo jumps up and down*");
        }
    }
}
