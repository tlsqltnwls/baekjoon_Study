using System;
using System.Collections.Generic;

namespace _1436
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int num = 666;

            for (int i = 2; i <= N; i++)
            {
                num += 1000;

                if (Check_num(num / 10))
                {
                    int num2 = num;
                    num2 = Change_num(num2);

                    for (i = i + 1; i <= N; i++)
                    {
                        if (!Check_num(num2 / 10) || !Check_num((num2 + 1) / 10))
                        {
                            num2 = num + 1000;
                            break;
                        }
                        else num2 += 1;
                    }
                    num = num2;
                }
            }
            Console.WriteLine(num);
        }


        static bool Check_num(int num) // 666이 존재하는지 확인용 함수
        {
            string num_str = num.ToString();
            
            bool check = num_str.Contains("666"); // true : 666 존재
            return check;
        }

        static int Change_num(int num) // 앞에 있는 666 이후의 수를 모두 0으로 바꾸는 함수
        {
            string num_str = num.ToString();
            char[] num_char = num_str.ToCharArray();

            int index = num_str.IndexOf("666");

            for (int i = index + 3; i < num_str.Length; i++)
                num_char[i] = '0';

            num_str = new string(num_char);
            return int.Parse(num_str);
        }
    }
}
