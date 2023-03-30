using System;
using System.Linq;
using System.Collections.Generic;

namespace _1259
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numList = new List<string>();
            string n;

            while (true)
            {
                n = Console.ReadLine();
                if (n == "0") break;
                numList.Add(n);
            }

            string[] num = numList.ToArray();
            string[] compareNum = new string[numList.Count];

            for (int i = 0; i < numList.Count; i++)
            {
                compareNum[i] = Reverse(num[i]);

                if (string.Equals(compareNum[i], num[i]))
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }

        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
            // chars.ToString() : 사용 가능한 문자열이 아닌 개체 유형을 나타내는 문자열을 만듦
            // new string(chars) : char 배열에 있는 모든 문자로 문자열을 만듦
        }
    }
}
