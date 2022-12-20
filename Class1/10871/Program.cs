using System;
using System.Text;

namespace _10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NX = Console.ReadLine().Split(' ');
            string[] A = Console.ReadLine().Split(' ');
            StringBuilder strB = new StringBuilder();

            for (int i = 0; i < int.Parse(NX[0]); i++)
            {
                if (int.Parse(NX[1]) > int.Parse(A[i])) 
                    strB.Append(A[i] + " ");
            }

            Console.WriteLine(strB);
        }
    }
}
