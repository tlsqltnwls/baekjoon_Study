using System;

namespace _2577
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            int[] check = new int[10];

            while (num > 0)
            {
                check[num % 10]++;
                num /= 10;
            }

/*            string str_num = num.ToString();

            for (int i = 0; i < str_num.Length; i++)
            {
                check[str_num[i] - 48]++;
            }*/

            foreach (var item in check)
            {
                Console.WriteLine(item);
            }
        }
    }
}
