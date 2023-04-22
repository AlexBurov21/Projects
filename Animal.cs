using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    abstract class Animal
    {
        public Animal(int age, Colors color, string name, int health, int attack)
        {
            this.Age = age;
            this.Color = color;
            this.Name = name;
            this.Health = health;
            this.Attack = attack;
        }
            public int Age { get; set; }
            public Colors Color { get; set; }
            public string Name { get; set; }
            public int Health { get; set; }
            public int Attack { get; set; }
            public Random Random;
    }
}
