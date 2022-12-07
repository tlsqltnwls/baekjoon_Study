using System;

namespace _1330
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] str_tmp = Console.ReadLine().Split(' ');

            if (Int32.Parse(str_tmp[0]) > Int32.Parse(str_tmp[1])) 
                Console.WriteLine(">");
            if (Int32.Parse(str_tmp[0]) < Int32.Parse(str_tmp[1])) 
                Console.WriteLine("<");
            if (Int32.Parse(str_tmp[0]) == Int32.Parse(str_tmp[1])) 
                Console.WriteLine("==");
            // else if 로 조건 나누는 것보다 그냥 if 여러개 쓰는게 더 빠름
        }
    }
}
