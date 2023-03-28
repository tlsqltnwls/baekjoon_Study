using System;

namespace _1085
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int x = int.Parse(str[0]);
            int y = int.Parse(str[1]);
            int w = int.Parse(str[2]);
            int h = int.Parse(str[3]);

            int x_ = x > (w - x) ? w - x : x;
            int y_ = y > (h - y) ? h - y : y;
            

            Console.WriteLine(x_ > y_ ? y_ : x_);
        }
    }
}
