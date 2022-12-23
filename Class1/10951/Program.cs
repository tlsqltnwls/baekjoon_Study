using System;
using System.Text;

namespace _10951
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strB = new StringBuilder();
            while(true)
            {
                String num = Console.ReadLine();
                
                if (String.IsNullOrEmpty(num)) break;

                strB.Append(((num[0] - 48) + (num[2] - 48)) + "\n");
            }

            Console.WriteLine(strB);
        }
    }
}
