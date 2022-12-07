using System;

namespace _1546
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            String[] arr = Console.ReadLine().Split(' ');
            float[] score = new float[N];

            float max = 0;
            float add = 0;

            for (int i = 0; i < N; i++)
            {
                score[i] = int.Parse(arr[i]);

                if (max < score[i]) max = score[i];
            }

            for (int i = 0; i < N; i++)
            {
                score[i] = (score[i] / max) * 100;
                add += score[i];
            }

            Console.WriteLine(add / N);
        }
    }
}
