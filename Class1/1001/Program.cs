using System;

namespace _1001
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp = Console.ReadLine();
            String[] str_tmp = temp.Split(' ');
            int A = Convert.ToInt32(str_tmp[0]);
            int B = Convert.ToInt32(str_tmp[1]);

            Console.WriteLine(A - B + " "+A + " "+ B);
            
        }
    }
}
