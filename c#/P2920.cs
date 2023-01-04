using System;

namespace P2920
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = "1 2 3 4 5 6 7 8";
            string str2 = "8 7 6 5 4 3 2 1";
            string input = Console.ReadLine();
            if(input == str)
                Console.WriteLine("ascending");
            else if(input == str2)
                Console.WriteLine("descending");
            else
                Console.WriteLine("mixed");
        }
    }
}