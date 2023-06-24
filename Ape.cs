using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Ape : Animal
    {
        public Ape(string type, string name, Colors color, int age) : base(type, name, color, age)
        {
        }

        public  void ApeSpin()
        {
            Console.WriteLine("*ape does spin and pounds chest*");
        }
    }
}
