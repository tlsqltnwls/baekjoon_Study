﻿using System;
using System.Text;

namespace _2741
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();

            for (int i = N; i > 0; i--)
            {
                str.Append((i) + "\n");
            }

            Console.WriteLine(str);
        }
    }
}
