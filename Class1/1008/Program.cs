using System;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp = Console.ReadLine();
            String[] str_temp = temp.Split(' ');

            double A = Convert.ToDouble(str_temp[0]);
            double B = Convert.ToDouble(str_temp[1]);

            /*double A = Convert.ToInt32(str_temp[0]);
            double B = Convert.ToInt32(str_temp[1]);*/

            Console.WriteLine(A/B);

            // parse : 문자열을 형변환해줌
            // convert : 모든 형을 바꿈 (char를 int 로 변환할 경우, 아스키 코드를 int 로 변환해줌)
            // str_temp[0] => string
            // temp [0] => char
        }
    }
}
