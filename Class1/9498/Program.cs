﻿using System;

namespace _9498
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (90 <= score) Console.WriteLine("A");
            else if (80 <= score) Console.WriteLine("B");
            else if (70 <= score) Console.WriteLine("C");
            else if (60 <= score) Console.WriteLine("D");
            else Console.WriteLine("F");
        }
    }
}
