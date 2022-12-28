using System;
using System.Collections.Generic;

namespace P1577
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine().ToUpper();
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (var ch in word)
            {
                if (result.Count == 0)
                    result.Add(ch, 1);
                else
                {
                    if (result.ContainsKey(ch))
                        result[ch]++;
                    else
                        result.Add(ch, 1);
                }
            }
            int maxvalue = 0;
            char output = ' ';
            foreach (var VARIABLE in result.Keys)
            {
                if (maxvalue < result[VARIABLE])
                {
                    maxvalue = result[VARIABLE];
                    output = VARIABLE;
                }
                else if(maxvalue == result[VARIABLE])
                {
                    output = '?';
                }
            }
            Console.WriteLine(output);
        }
    }
}