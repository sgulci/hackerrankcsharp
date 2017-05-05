using System;

namespace WarmupChallenges
{
    public class Staircase
    {

        public static void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            solution(n);
        }

        static void solution(int n)
        {
            string result = "";
            string sharp = "#";
            string empty = " ";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (n - i < j)
                        result += sharp;
                    else
                        result += empty;                   
                }
                result += "\n";
            }

            Console.WriteLine(result);
        }
    }
}
