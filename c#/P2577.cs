﻿using System;

namespace P2577
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num = new int[3];
            int[] count = new int[10];
            int multi = 1;
            for (int i = 0; i < 3; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                multi *= num[i];
            }
            string mulitstr = multi.ToString();
            foreach (var VARIABLE in mulitstr)
            {
                switch (VARIABLE)
                {
                    case '0':
                        count[0]++;
                        break;
                    case '1':
                        count[1]++;
                        break;
                    case '2':
                        count[2]++;
                        break;
                    case '3':
                        count[3]++;
                        break;
                    case '4':
                        count[4]++;
                        break;
                    case '5':
                        count[5]++;
                        break;
                    case '6':
                        count[6]++;
                        break;
                    case '7':
                        count[7]++;
                        break;
                    case '8':
                        count[8]++;
                        break;
                    case '9':
                        count[9]++;
                        break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(count[i]);
            }

        }
    }
}