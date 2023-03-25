using System.ComponentModel.Design;

namespace ShoppingList
{
    internal class Program
    {
        /*
         * Create a shopping list program
         * 3 main operations you can do:
         * Add to the array
         * Remove from the array
         * View the content of the array
         * (exit)
         * 
         * Make a function that expands the array
         */

        //static string[] StringArr() { }
        static string[] list = new string[1];
        static int count = 0;
        static bool running = true;
        static bool checkArray(string userInput)
        {
            for (int i = 0; i < count; i++)
            {
                if (list[i] == userInput)
                {
                    return false;
                }
            }
            return true;
        }
        static void printList()
        {
            for (int i = 0; i < count + 1; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void resize()
        {
            if (list.Length >= count)
            {
                string[] temp = new string[count * 2];
                for (int i = 0; i < list.Length; i++)
                {
                    temp[i] = list[i];
                }
                list = temp;
            }
        }
        static void giveOptionsChoices()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Alexander's Shopping List Program! Please input the action you would like to exectute:");
            Console.WriteLine("-View list");
            Console.WriteLine("-Add to list");
            Console.WriteLine("-Remove from list");
            Console.WriteLine("-Exit :(");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse == "view list" || userResponse == "view")
            {
                printList();
            }
            else if (userResponse == "add to list" || userResponse == "add")
            {
                count++;
                resize();
                bool notInArray = false;
                while (notInArray == false)
                {
                    Console.WriteLine("Please input a new item for your list:");
                    string addedItem = Console.ReadLine();
                    if (checkArray(addedItem) == false)
                    {

                    }
                    if (addedItem == "nevermind" || addedItem == "never mind")
                    {
                        count--;
                        Console.WriteLine("Returning you to menu...");
                        notInArray = true;
                    }

                    else if (addedItem == null)
                    {

                    }
                    else
                    {
                        list[count] = addedItem;
                        printList();
                        notInArray = true;
                    }
                }
            }
            else if (userResponse == "remove" || userResponse == "remove from list" || userResponse == "subtract from list" || userResponse == "subtract")
            {
                bool notInList = true;
                while (notInList == true)
                {
                    Console.WriteLine("Please input an item you want to remove from your list:");
                    string removedItem = Console.ReadLine();
                    if (checkArray(removedItem) == false)
                    {
                        
                    }
                    if (removedItem == "nevermind" || removedItem == "never mind")
                    {
                        Console.WriteLine("Returning you to menu...");
                        notInList = false;
                    }

                    else if (removedItem == null)
                    {

                    }
                    else
                    {
                        notInList = false;
                        list[count] = null;
                        count--;
                        printList();
                    }
                }
            }
            else if (userResponse == "false")
            {
                Console.WriteLine("Goodbye :(");
                running = false;
            }
            else { }
        }
        static void Main(string[] args)
        {
            while (running = true)
            {
                giveOptionsChoices();
            }
        }
    }
}