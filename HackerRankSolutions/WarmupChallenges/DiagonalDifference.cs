using System;
using System.Linq;


namespace WarmupChallenges
{
    public class DiagonalDifference
    {
        public static void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[n][];

            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            Console.WriteLine(solution(n ,a));
        }

        static int solution(int n, int[][] a)
        {
            int res1 = 0;
            int res2 = 0;
            for (int i = 0; i < n; i++)
            {
               res1 += a[i][i];
            }

            for (int i = 0; i < n; i++)
            {
                res2 += a[i][(n -1) - i];
            }

            return Math.Abs(res1 - res2);
        }
    }
}
