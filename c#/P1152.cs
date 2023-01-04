using System;
using System.Collections.Generic;
using System.Linq;

namespace P1152
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine().Trim();
            string[] strarray = word.Split(' ');
            int size = strarray.Length;
            for (int i = 0; i < strarray.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(strarray[i]))
                {
                    size--;
                }
            }
            Console.WriteLine(size);
        }
    }
}