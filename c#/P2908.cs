using System;
using System.Text;

namespace P2908
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] Testcase = Console.ReadLine().Split(' ');
            int[] num = new int[2];
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                for (int j = Testcase[i].Length - 1; j >= 0 ; j--)
                {
                    builder.Append(Testcase[i][j]);
                }
                num[i] = Convert.ToInt32(builder.ToString());
                builder.Clear();
            }
            Console.WriteLine(num[0] > num[1] ? num[0] : num[1]);
        }
    }
}