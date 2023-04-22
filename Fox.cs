using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    
    internal class Fox : Animal
    {
        public Fox(int age, Colors color, string name, int health, int attack) : base(age, color, name, health, attack) { }

        public int AttackAnimal(Animal target)
        {
            int AttackNum;
            if (Color == Colors.Red && target.Color == Colors.Green)
            {
                AttackNum = Attack * 2;
            }
            else if (Color == Colors.Blue && target.Color == Colors.Red)
            {
                AttackNum = Attack * 2;
            }
            else if (Color == Colors.Green && target.Color == Colors.Blue)
            {
                AttackNum = Attack * 2;
            }
            else
            {
                AttackNum = Attack;

            }
            Random random= new Random();
            int buff = random.Next(0, 10);
            AttackNum += buff;
            target.Health -= AttackNum;
            return AttackNum;
        }
    }
}
