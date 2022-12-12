using System;
using System.Text;

namespace _2741
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                str.Append((i + 1) + "\n");
            }

            Console.WriteLine(str);
        }
    }
}
