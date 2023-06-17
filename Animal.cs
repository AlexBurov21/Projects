using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
     class Animal
    {
        public Animal(string type, string name, Colors color, int age)
        {
            this.Type = type;
            this.Name = name;
            this.Color = color;
            this.Age = age;

        }

        public virtual void SpecialAction()
        {
            Console.WriteLine("HELLO");
        }
        public int Age { get; set; }
        public Colors Color { get; set; }
        public string Name { get; set; }
        
        public string Type { get; set; }
    }
}
