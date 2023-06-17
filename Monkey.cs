using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Monkey : Animal
    {
        public Monkey(string type, string name, Colors color, int age) : base(type, name, color, age)
        {
        }

        public virtual void MonkeyMoment()
        {
            Console.WriteLine("OOO OOO OOO OOO AAAAAAAAAAAAAAAAAA");
        }
    }
}
