using System.Security.Cryptography.X509Certificates;

namespace ClassPractice
{
        //Make classes for animals
        enum Colors
        {
            Red,
            Blue,
            Green,
        }
    internal class Program
    {
    /*
        //public, private, protected
        abstract class Shape
        {
            public Shape(int x, int y, int width, int height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }

            public int x { get; set; }
            public int y { get; set; }
            public int width { get; set; }
            public int height { get; set; }

            public abstract void Draw();

            public virtual void Print()
            {
                Console.WriteLine("This is a shape");
            }
        }

        class Rectangle : Shape
        {
            public int color { get; set; }

            public Rectangle (int x, int y, int width, int height, int color) : base(x, y, width, height)
            {
                this.color = color;
            }

            public void DoSomething(int val)
            {
                x -= val;
            }

            public override void Draw()
            {
                
            }

            public override void Print()
            {
                base.Print();
                Console.WriteLine("Rectangle");
            }
        }
        class Circle : Shape
        {
            public int radius { get; set; }

            public Circle(int x, int y, int width, int height, int radius) : base(x, y, width, height)
            {
                this.radius = radius;
            }
            public override void Draw()
            {

            }
        }
        */
        static void Battle(Fox fox, Lizard lizard)
        {
            while (lizard.Health > 0 && fox.Health > 0)
            {
                int FoxAttacked = fox.AttackAnimal(lizard);
                if (lizard.Health < 0)
                {
                    lizard.Health = 0;
                }
                Console.WriteLine($"{fox.Name} hits {lizard.Name} for {FoxAttacked} hit points. {lizard.Name} is now at {lizard.Health} health");
                Console.WriteLine("Continue?");
                Console.ReadLine();
                if(lizard.Health <= 0)
                {
                    break;
                }
                int LizardAttacked = lizard.AttackAnimal(fox);
                if (fox.Health < 0)
                {
                    fox.Health = 0;
                }
                Console.WriteLine($"{lizard.Name} hits {fox.Name} for {LizardAttacked} hit points. {fox.Name} is now at {fox.Health} health");
            }
            if (lizard.Health <= 0)
            {
                Console.WriteLine($"{fox.Name} wins!");
            }
            else if (fox.Health <= 0)
            {
                Console.WriteLine($"{lizard.Name} Wins!");
            }
        }
        static void Main(string[] args)
        {
            /*
            List<Shape> list = new List<Shape>();

            list.Add(new Rectangle(10, 10, 20, 20, 5));
            list.Add(new Circle(10, 23, 41, 5, 52));

            list[0].Print();
            list[1].Print();
            Rectangle r = list[0] as Rectangle;
            if(r != null)
            {
                r.color = 1;
            }
            */
            Fox foxReginald = new Fox(11, Colors.Green, "Reggie", 20, 10);
            Lizard lizardBanana = new Lizard(2, Colors.Red, "BANANA", 17, 5);
            Battle(foxReginald, lizardBanana);
        }
    }
}