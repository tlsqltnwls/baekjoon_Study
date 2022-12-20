using System;

namespace _10818
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split(' ');
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < N; i++)
            {
                if (int.Parse(num[i]) > max) max = int.Parse(num[i]);
                if (int.Parse(num[i]) < min) min = int.Parse(num[i]);
            }

            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
