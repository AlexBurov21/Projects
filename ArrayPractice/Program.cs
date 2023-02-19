namespace ArrayPractice
{
    internal class Program
    {
        //Revese a string 
        static void StringReverse(string strInput)
        {
            for (int i = strInput.Length - 1; i >= 0; i--)
            {
                Console.Write($"{strInput[i]}");
            }
        }

        //Swap the two halves of an array :    1, 2, 3, 4, 5, 6, 7, 8 -> 5, 6, 7, 8, 1, 2, 3, 4
        static void StringSwap(string strInput)
        {
            for(int i = 0, i <= strInput / 2)
            {
                Console.Write();
            }
        }
    //Check if a string is palindrome
    static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            StringReverse(strInput);
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}