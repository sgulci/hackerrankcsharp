using System;

namespace WarmupChallenges
{
    public class PlusMinus
    {
        public static void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            Console.WriteLine(String.Join("\n", solution(arr)));
        }

        static decimal[] solution(int[] arr)
        {
            decimal[] result = new decimal[3];
            int positive = 0, negative = 0, zero = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                positive += arr[i] > 0 ? 1 : 0;
                negative += arr[i] < 0 ? 1 : 0;
                zero += arr[i] == 0 ? 1 : 0;
            }

            result[0] = (decimal)positive / arr.Length;
            result[1] = (decimal)negative / arr.Length;
            result[2] = (decimal)zero / arr.Length;

            return result;
        }
    }
}
