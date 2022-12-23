using System;

namespace _11720
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string num = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < N; i++)
                sum += (num[i] - 48);

            Console.WriteLine(sum);
        }
    }
}
