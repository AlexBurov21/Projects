using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace Zoo
{
    enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Brown,
        Black,
        Orange,
        Pink,
        Purple,
        Striped
    }
    
    internal class Program
    {

        //Zoo with animal parent class
        //Animals all have name, color, age, action
        //Some animals have a class that has a special action: jump, eating worms, etc
        //People can see the animals, or bring in their own animals into the zoo
        //Max of 15 animals
        //Use polymorphism 
        //Be able to search for animals by name, color, or age and show all animals with that characterstic


        static void Main(string[] args)
        {
            string userInput = "";
            int animalChoice = 0;
            bool running = true;
            Animal[] animalList = new Animal[]
            {
                new Ape("Ape", "Jeb", Colors.Black, 7),
                new Kangaroo("Kangaroo", "Steve", Colors.Brown, 3),
                new Monkey("Monkey", "Daniel", Colors.Brown, 5),
                new Bird("Bird", "Jonas", Colors.Green, 1)
            };
            while (running ==  true)
            {
                Console.WriteLine("Welcome to the zoo! What would you like to do? (input the number of the action you would like to execute.)");
                Console.WriteLine("(1) View animals");
                Console.WriteLine("(2) Bring a new animal into the zoo");
                Console.WriteLine("(3) Exit");
                userInput = Console.ReadLine();
                bool running2 = true;
                if(userInput == "1")
                {
                    while (running2 ==  true)
                    {
                        Console.WriteLine("What animal would you like to view");
                        for (int i = 0; i < animalList.Length; i++)
                        {
                            Console.WriteLine($"({i + 1}) {animalList[i].Type}");
                        }
                        bool wasParsed = false;
                        while(wasParsed = false)
                        { 
                            wasParsed = int.TryParse(Console.ReadLine(), out animalChoice);
                            if (!wasParsed || animalChoice > animalList.Length || animalChoice < 0)
                            {
                                Console.WriteLine("Invalid input");
                            }
                            else wasParsed = true;
                        }

                        Console.WriteLine($"{animalList[animalChoice]}");
                        
                    }
                }
            }
            
            
        }
    }
}