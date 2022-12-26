using System;
using System.Text;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int M = int.Parse(num[0]);
            int N = int.Parse(num[1]);

            string[] str = new string[M];

            for (int i = 0; i < M; i++)
            {
                str[i] = Console.ReadLine();
            }

            Check(str, M, N);
        }

        static void Check(string[] s, int M, int N)
        {
            string check = s[M][N].ToString();
            int c = 1;
            int count = 0;
            int count_check = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (string.Equals(check, s[M + i][N + j])) count++;
                    else
                    {
                        count_check++;
                        c *= -1;
                    }
                    c *= -1;
                }
            }
            
            
        }
    }
}
