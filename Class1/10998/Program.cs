using System;

namespace _10998
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            Console.WriteLine((num[0] - 48) * (num[2] - '0'));
        }
    }
}
