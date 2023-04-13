using System;

namespace _1874
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            int[] stack = new int[n];

            //for (int i = 0; i < n; i++)
            //    sequence[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("전: " + n);
            test(n);
            Console.WriteLine("후: " + n);
        }

        static void test (int n)
        {
            n = 5;
            Console.WriteLine(" 테스트 중: " + n);
        }
    }
}
