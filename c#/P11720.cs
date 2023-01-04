using System;

namespace P11720
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string Snum = Console.ReadLine();
            int result = 0;
            foreach (var VARIABLE in Snum)
            {
                result += Convert.ToInt32(VARIABLE) - 48;
            }
            Console.WriteLine(result);
        }
    }
}