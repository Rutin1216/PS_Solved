using System;

namespace P2562
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num = new int[9];
            int max = 0, index = 0;
            for (int i = 0; i < 9; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    max = num[i];
                    index = i + 1;
                }
                else if(num[i] > max)
                {
                    max = num[i];
                    index = i + 1;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(index);
        }
    }
}