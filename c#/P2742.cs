using System;
using System.Text;

namespace P2742
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            for (int i = num; i > 0; i--)
            {
                builder.Append(i + "\n");
            }
            Console.WriteLine(builder);
        }
    }
}