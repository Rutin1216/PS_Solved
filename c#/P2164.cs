using System;
using System.Collections;

namespace P2164
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue num = new Queue();
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                num.Enqueue(i);
            }
            while (num.Count != 1)
            {
                num.Dequeue();
                num.Enqueue(num.Dequeue());
            }
            Console.WriteLine(num.Dequeue());
        }
    }
}