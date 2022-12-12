using System;

namespace _2739
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(N + " * " + (i + 1) + " = " + (N * (i + 1)));
            }
        }
    }
}
