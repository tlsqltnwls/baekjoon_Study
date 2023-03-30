using System;
using System.Linq;

namespace _1181
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] arr = new string[N];

            for (int i = 0; i < N; i++)
                arr[i] = Console.ReadLine();

            string[] distArr = arr.Distinct().ToArray();
            // .ToArray() : List를 배열로 변환하는 방법
            // IEnumerable 인터페이스에서 배열로 변환해주기 위해 .ToArray() 사용

            Array.Sort(distArr);
            // 사전 순 정렬
            distArr = distArr.OrderBy(a => a.Length).ToArray();
            // 길이가 짧은 순 정렬
                       
            foreach (var item in distArr)
                Console.WriteLine(item);
        }
    }
}


// 참고 사이트 : https://bit.ly/3ZjPGVn