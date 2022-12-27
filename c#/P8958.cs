using System;
using System.Text;

namespace P8958
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int cnt = 0, add = 0;
            StringBuilder builder = new StringBuilder();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                builder.Append(Console.ReadLine());
                foreach (var VARIABLE in builder.ToString())
                {
                    if (VARIABLE == 'O')
                        add += ++cnt;
                    else
                        cnt = 0;
                }
                builder.Clear();
                result.Append(add + "\n");
                add = 0;
                cnt = 0;
            }
            Console.WriteLine(result);
        }
    }
}