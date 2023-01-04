using System;

namespace P2884
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            string[] num = Console.ReadLine().Split(' ');
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(num[i]);
            }

            Array.Sort(arr);
            Console.WriteLine(arr[0]+ " "+ arr[count-1]);
        }
    }
}