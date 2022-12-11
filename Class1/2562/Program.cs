using System;

namespace _2562
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[9];
            int max = 0;
            int index = 0;

            for (int i = 0; i < 9; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

                if (max < num[i])
                {
                    max = num[i];
                    index = i + 1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(index);
        }
    }
}
