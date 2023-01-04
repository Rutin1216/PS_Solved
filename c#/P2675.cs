using System;
using System.Text;

namespace P2675
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            string testcase;
            
            for (int i = 0; i < num; i++)
            {
                testcase = Console.ReadLine();
                int Rnum = Convert.ToInt32(testcase.Substring(0,1));
                string str = testcase.Substring(2);
                foreach (var VARIABLE in str)
                {
                    for (int j = 0; j < Rnum; j++)
                    {
                        builder.Append(VARIABLE);
                    }
                }

                builder.Append("\n");
            }
            Console.WriteLine(builder);
        }
    }
}