using System;

namespace _10952
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] num = Console.ReadLine().Split(' ');

                if (string.Equals(num[0], "0") && string.Equals(num[1], "0")) break;
                Console.WriteLine(int.Parse(num[0]) + int.Parse(num[1]));
            }
        }
    }
}
