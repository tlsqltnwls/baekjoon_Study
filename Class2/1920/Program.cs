using System;
using System.IO;

namespace _1920
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader strR = new StreamReader(Console.OpenStandardInput());
            StreamWriter strW = new StreamWriter(Console.OpenStandardOutput());

            int N = int.Parse(strR.ReadLine());
            int[] N_num = Array.ConvertAll(strR.ReadLine().Split(' '), int.Parse);
            // Array.ConvaerAll(여기 있는걸, 작성한 형으로 전부 바꿔줌)
            Array.Sort(N_num);

            int M = int.Parse(strR.ReadLine());
            int[] M_num = Array.ConvertAll(strR.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < M; i++)
                strW.WriteLine(binary(M_num[i], N_num));

            strR.Close();
            strW.Close();
        }

        static int binary(int value, int[] N)
            // 이진 탐색
        {
            int left = 0;
            int right = N.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (value < N[mid])
                    right = mid - 1;
                else if (value > N[mid])
                    left = mid + 1;
                else return 1;
            }

            return 0;
        }
    }
}
