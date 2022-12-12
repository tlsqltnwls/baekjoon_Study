using System;

namespace _2675
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                String[] S_arr = Console.ReadLine().Split(' ');
                string S = S_arr[1];
                int R = int.Parse(S_arr[0]);
                int count = 0;

                for (int j = 0; j < S.Length; j++)
                {
                    count = 0;
                    while (count < R)
                    {
                        Console.Write(S[j]);
                        count++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
