using System;

namespace P1330
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int[] result = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = Convert.ToInt32(array[i]);
            }
            if(result[0] > result[1])
                Console.WriteLine('>');
            else if(result[0] < result[1])
                Console.WriteLine('<');
            else if(result[0] == result[1])
                Console.WriteLine("==");
        }
    }
}