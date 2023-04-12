using System;
using System.Linq;

namespace _1654
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ');
            int K = int.Parse(str[0]);
            int N = int.Parse(str[1]);

            long[] Kcm = new long[K];
            long sum_Kcm = Kcm.Sum();
            for (int i = 0; i < K; i++)
            {
                Kcm[i] = long.Parse(Console.ReadLine());
                sum_Kcm += Kcm[i];
            }            
            
            long min_Cm = 1, max_Cm = sum_Kcm / N;
            long answer = 0;

            while (min_Cm <= max_Cm)
            {
                long avg_Cm = (min_Cm + max_Cm) / 2;

                int count = 0;

                for (int i = 0; i < K; i++)
                    count += (int)(Kcm[i] / avg_Cm);

                if (count >= N)
                {
                    answer = avg_Cm;
                    min_Cm = avg_Cm + 1;
                }
                else
                    max_Cm = avg_Cm - 1;
            }

            Console.WriteLine(answer);
        }
    }
}
