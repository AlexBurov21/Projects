using System.Runtime.CompilerServices;

namespace Bank
{
    // Bugs: need to stay logged in.
    internal class Program
    {
        static Account[] accounts = new Account[0];
        static void resize()
        {
            Account[] temp = new Account[accounts.Length + 1];
            for (int i = 0; i < accounts.Length; i++)
            {
                temp[i] = accounts[i];
            }
            accounts = temp;
        }
        static void Main(string[] args)
        {

            bool running = true;

            
            while (running == true)
            {
                Console.WriteLine("Welcome! Please select an option:");
                Console.WriteLine("1) Log in with an existing account");
                Console.WriteLine("2) Create a new account");
                Console.WriteLine("3) Exit");
                Console.WriteLine();
                string firstScreenResponse = Console.ReadLine();
                if (firstScreenResponse == null) { }
                else if (firstScreenResponse == "1" && accounts.Length == 0)
                {
                    Console.WriteLine("There are no existing accounts.");
                }
                else if (firstScreenResponse == "1" && accounts.Length > 0)
                {
                    Console.WriteLine("Please input your username. If you would like to exit, please input 'exit'.");
                    string userLogIn = Console.ReadLine();
                    string passLogIn = "";
                    string userChoice = "";
                    int addAmount = 0;
                    bool loggedIn = false;
                    if (userLogIn == "exit" || userLogIn == "")
                    {
                        break;
                    }
                    for (int i = 0; i < accounts.Length; i++)
                    {
                        if (userLogIn == accounts[i].username && accounts[i].failedAttempts < 3)
                        {
                            Console.WriteLine($"Please input your password,{accounts[i].username} (Failed Attempts[{accounts[i].failedAttempts}])");
                            passLogIn = Console.ReadLine();
                            if (passLogIn == accounts[i].password)
                            {
                                loggedIn = true;
                                while(loggedIn == true)
                                {
                                    Console.WriteLine($"Welcome, {accounts[i].username}! Please select an option:");
                                    Console.WriteLine("1) View your balance.");
                                    Console.WriteLine("2) Add money to your account.");
                                    Console.WriteLine("3) Retrieve money from your account.");
                                    Console.WriteLine("4) Exit to menu");
                                    userChoice = Console.ReadLine();
                                    if (userChoice == "1")
                                    {
                                        Console.WriteLine($"Your balance in your account is currently: {accounts[i].balance}");
                                        Console.WriteLine($"Your balance on hand is currently; {accounts[i].moneyOnHand}");
                                    }
                                    else if (userChoice == "2")
                                    {
                                        Console.WriteLine("What amount would you like to add?");
                                        bool wasParsed = int.TryParse(Console.ReadLine(), out addAmount);
                                        if (!wasParsed || addAmount > accounts[i].moneyOnHand || addAmount <= 0)
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        else
                                        {
                                            accounts[i].balance += addAmount;
                                            accounts[i].moneyOnHand -= addAmount;
                                            Console.WriteLine($"Your balance in your account is currently: {accounts[i].balance}");
                                            Console.WriteLine($"Your balance on hand is currently; {accounts[i].moneyOnHand}");
                                        }

                                    }
                                    else if (userChoice == "3")
                                    {
                                        Console.WriteLine($"What amount would you like to retrieve(you currently have ${accounts[i].balance} in your account)?");
                                        bool wasParsed = int.TryParse(Console.ReadLine(), out addAmount);
                                        if (!wasParsed || addAmount > accounts[i].balance || addAmount <= 0)
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        else
                                        {
                                            accounts[i].balance -= addAmount;
                                            accounts[i].moneyOnHand += addAmount;
                                            Console.WriteLine($"Your balance in your account is currently: {accounts[i].balance}");
                                            Console.WriteLine($"Your balance on hand is currently; {accounts[i].moneyOnHand}");
                                        }
                                    }
                                    else if(userChoice == "4")
                                    {
                                        loggedIn = false;
                                    }
                                } 
                            }
                            else
                            {
                                accounts[i].failedAttempts++;
                                Console.WriteLine($"Incorrect password. You have {3 - accounts[i].failedAttempts} remaining.");
                                if (accounts[i].failedAttempts >= 3)
                                {
                                    Console.WriteLine("You have now reached the maximum amount of failed log in attempts. This account is now locked until further notice.");
                                    break;
                                }
                            }
                           
                        }
                        else if (userLogIn != accounts[i].username && accounts[i].failedAttempts !< 3)
                        {
                            Console.WriteLine("This account either doesn't exist, or it is locked.");
                        }
                    }
                    

                }

                else if (firstScreenResponse == "2")
                {
                    bool input1 = false;
                    string setUserName = "";
                    string setpassword = "";
                    while (input1 == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please input a username: ");
                        setUserName = Console.ReadLine();
                        if (accounts.Length >= 1)
                        {
                            for(int i = 0; i <  accounts.Length; i++)
                            {
                                if (setUserName == "" || setUserName == accounts[i].username) 
                                {
                                    Console.WriteLine("This username is invalid/taken.");
                                    break;
                                }
                                else input1= true;
                            }
                        }
                        else 
                        {
                            input1 = true;
                        }
                    }
                    bool input2 = false;
                    while (input2 == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please input a password: ");
                        setpassword = Console.ReadLine();

                        if (setpassword == "") { }
                        else { input2 = true; }
                    }
                    resize();
                    accounts[accounts.Length - 1] = new Account(setUserName, setpassword, 0, 0, 120000);
                }

                else if(firstScreenResponse == "3")
                {
                    break;
                }
            }
        }
    }
}