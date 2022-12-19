using System;

namespace _8958
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_size = int.Parse(Console.ReadLine());
            string testOX;
            int score = 0;
            int sum = 0;

            for (int i = 0; i < test_size; i++)
            {
                testOX = Console.ReadLine();

                for (int j = 0; j < testOX.Length; j++)
                {
                    if (testOX[j] == 'O') sum += ++score;
                    else score = 0;
                }

                Console.WriteLine(sum);
                score = 0;
                sum = 0;
            }
        }
    }
}
