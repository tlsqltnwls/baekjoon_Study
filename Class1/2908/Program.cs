using System;

namespace _2908
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');

            var num1 = num[0].ToCharArray();
            Array.Reverse(num1);
            var num2 = num[1].ToCharArray();
            Array.Reverse(num2);

            if (int.Parse(num1) > int.Parse(num2)) Console.WriteLine(num1);
            else Console.WriteLine(num2);
        }
    }
}
