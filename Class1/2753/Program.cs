﻿using System;

namespace _2753
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("1");
            }
            else Console.WriteLine("0");
        }
    }
}
