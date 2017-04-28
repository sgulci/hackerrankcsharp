
using System;
using System.Linq;

namespace WarmupChallenges
{
    public class Mini_MaxSum
    {
        public static void Solve()
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, long.Parse);

            solution(arr);
        }


        static void solution(long[] arr)
        {
            long[] sums = new long[5];
            long sumOfOneLine;

            for (int i = 0; i < 5; i++)
            {
                sumOfOneLine = 0;

                for (int j = 0; j < 5; j++)
                {
                    if (i != j )
                    {
                        sumOfOneLine += arr[j];
                    }
                }

                sums[i] = sumOfOneLine;
            }

            Console.WriteLine(sums.Min() + " " + sums.Max()); ;
        }
    }
}
