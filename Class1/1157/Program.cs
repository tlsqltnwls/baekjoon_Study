using System;
using System.Collections;

namespace _1157
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine().ToUpper();
            int[] count = new int[26];

            int t;

            int max = 0;
            int check = 0;
            int index = 0;

            for (int i = 0; i < str.Length; i++)
            {
                count[str[i] - 'A']++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] >= max)
                {                    
                    if (count[i] == max) check = 1;
                    else
                    {
                        max = count[i];
                        check = 0;
                        index = i;
                    }
                }
            }


            if (check == 1) Console.WriteLine("?");
            else
            {
                t = index + 'A';
                char test = (char)t;

                Console.WriteLine(test);
            }
        }
    }
}
