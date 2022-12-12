using System;

namespace _2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(' ');

            int H = int.Parse(time[0]);
            int M = int.Parse(time[1]) - 45;

            if (M < 0)
            {
                if (H == 0) H = 23;
                else H -= 1;
                M += 60;
            }
            
            Console.WriteLine(H + " " + M);
        }
    }
}
