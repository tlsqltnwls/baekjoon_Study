using System;

namespace _10950
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(num[0]) + int.Parse(num[1]));
            }
        }
    }
}
