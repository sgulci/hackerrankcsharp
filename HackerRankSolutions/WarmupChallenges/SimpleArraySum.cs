using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace WarmupChallenges
{
    public class SimpleArraySum
    {
        public static void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);


            Console.WriteLine(arr.Sum()); 
        }
    }
}
