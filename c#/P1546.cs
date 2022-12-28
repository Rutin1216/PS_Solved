using System;

namespace P1546
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string[] score = Console.ReadLine().Split(' ');
            double[] myscore = new double[num];
            for (int i = 0; i < num; i++)
            {
                myscore[i] = Convert.ToDouble(score[i]);
            }

            Array.Sort(myscore);
            double max = myscore[num-1];
            double avg = 0;
            for (int i = 0; i < num; i++)
            {
                myscore[i] = myscore[i] / max * 100;
                avg += myscore[i];
            }
            avg /= num;
            Console.WriteLine(avg);
        }
    }
}