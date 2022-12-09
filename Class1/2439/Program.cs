using System;

namespace _2439
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                for (int j = N - i - 1; j > 0; j--)
                {
                    Console.Write(" ");

                }
                for (int j = -1; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
