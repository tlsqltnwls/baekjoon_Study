using System;

namespace _2475
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] unique_num = new double[5];
            String[] temp = Console.ReadLine().Split(' ');
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                unique_num[i] = double.Parse(temp[i]);
                sum += Math.Pow(unique_num[i], 2);
            }

            Console.WriteLine(sum % 10);
        }
    }
}
