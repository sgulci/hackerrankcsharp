using System;

namespace WarmupChallenges
{
    public class BirthdayCakeCandles
    {
        public static void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);

            solution(n,height);
        }

        static void solution(int n, int[] heights)
        {
            int tallest = 0;
            for (int i = 0; i < n; i++)
            {
                if (tallest < heights[i])
                {
                    tallest = heights[i];
                }
            }

            int tallestCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (heights[i] == tallest)
                {
                    tallestCount++;
                }
            }
            Console.WriteLine(tallestCount);
        }
    }
}
