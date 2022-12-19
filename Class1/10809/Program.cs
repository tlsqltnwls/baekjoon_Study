using System;

namespace _10809
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int[] eng = new int[26];

            for (int i = 0; i < 26; i++) eng[i] = -1;
            for (int i = S.Length - 1; i > -1; i--) eng[S[i] - 97] = i;

            foreach (var item in eng) Console.Write(item + " ");
        }
    }
}
