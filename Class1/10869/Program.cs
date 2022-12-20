using System;

namespace _10869
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);

            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);
        }
    }
}
