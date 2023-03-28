using System;
using System.Text;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int M = int.Parse(num[0]); // 세로 길이
            int N = int.Parse(num[1]); // 가로 길이

            string[] str = new string[M];

            int check = 0;
            int min = int.MaxValue;

            for (int i = 0; i < M; i++) str[i] = Console.ReadLine();

            for (int i = 0; i < M - 7; i++)
            {
                for (int j = 0; j < N - 7; j++)
                {
                    check = Check(str, i, j);
                    if (check < min)  min = check;
                }
            }

            Console.WriteLine("======================");
            Console.WriteLine(min);
        }

        static int Check(string[] s, int M, int N)
        {
            string check = s[M][N].ToString(); // s[세로크기][가로크기]
            int color = -1; // 1 = black , -1 = white
            int count = 0;
            int count_check = 0;

            Console.WriteLine("check: " + check);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0) // 세로가 0 2 4 .. 인 경우
                    {
                        if (((j % 2 == 0) && string.Equals(check, s[M + i][N + j].ToString()))
                            || ((j % 2 != 0) && !string.Equals(check, s[M + i][N + j].ToString())))
                        //  0 2 4 .. 짝수 번째 & 체크랑 글이 같음
                        // 1 3 5 .. 홀수 번째 & 체크랑 글이 다름
                        // 좋은 상태!
                            count_check++;
                        else
                        // 1 3 5 ... 홀수 번째 & 체크랑 글이 같음
                        // 0 2 4 .. 짝수 번째 & 체크랑 글이 다름
                        // 글자를 바꿔야 되는 상태!
                            count++;
                    }
                    else // 세로가 1 3 5 .. 인 경우
                    {
                        if (((j % 2 == 0) && !string.Equals(check, s[M + i][N + j].ToString()))
                            || ((j % 2 != 0) && string.Equals(check, s[M + i][N + j].ToString())))
                        //  0 2 4 .. 짝수 번째 & 체크랑 글이 다름
                        // 1 3 5 .. 홀수 번째 & 체크랑 글이 같음
                        // 좋은 상태!
                        {
                            count_check++;
                            Console.WriteLine("3. j: " + j + "   i: " + i + "   좋은 상태!   현재 count: " + count + "   count_check: " + count_check + "   stirng.Equlas: " + string.Equals(check, s[M + i][N + j].ToString()));
                            
                        }
                        else
                        // 1 3 5 ... 홀수 번째 & 체크랑 글이 다름
                        // 0 2 4 .. 짝수 번째 & 체크랑 글이 같음
                        // 글자를 바꿔야 되는 상태!
                        {
                            count++;
                            Console.WriteLine("4. j: " + j + "   i: " + i + "   나쁜 상태!   현재 count: " + count + "   count_check: " + count_check + "   stirng.Equlas: " + string.Equals(check, s[M + i][N + j].ToString()));
                            
                        }
                    }
                }
            }
            Console.WriteLine("count: " + count + "   count_check: " + count_check);

            return count < count_check ? count : count_check;
        }
    }
}
