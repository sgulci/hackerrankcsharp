using System;
using System.Linq;

namespace WarmupChallenges
{
    public class AVeryBigSum
    {
        public static void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);

            Console.WriteLine(arr.Sum());
        }


    }
}
