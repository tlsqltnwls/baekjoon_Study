using System;

namespace _1000
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp = Console.ReadLine();
            String[] str_tmp = temp.Split(' ');
            int A = Convert.ToInt32(str_tmp[0]);
            int B = Convert.ToInt32(str_tmp[1]);

            if (A > 0 && B < 10) Console.WriteLine(A + B);
        }
    }
}
