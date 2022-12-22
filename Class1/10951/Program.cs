using System;

namespace _10951
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(num[0]) + int.Parse(num[1]));
            }
            
        }
    }
}
