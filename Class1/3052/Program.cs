using System;

namespace _3052
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[42];
            int count = 0;

            for (int i = 0; i < 10; i++)
                num[(int.Parse(Console.ReadLine()) % 42)]++;
            for (int i = 0; i < 42; i++)
                if (num[i] > 0) count++;

            Console.WriteLine(count);
        }
    }
}
