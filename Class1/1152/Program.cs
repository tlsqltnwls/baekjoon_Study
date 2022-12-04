using System;

namespace _1152
{
    class Program
    {
        static void Main(string[] args)
        {
            String A = Console.ReadLine();
            String[] B = A.Split(' ');

            // int len = B.Length;
            int count = 0;

            if (B[0].Length == 0) count++;
            if (B[B.Length - 1].Length == 0) count++;

            Console.WriteLine(B.Length - count);
        }
    }
}
