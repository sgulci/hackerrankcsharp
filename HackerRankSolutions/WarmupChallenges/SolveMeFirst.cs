﻿using System;

namespace WarmupChallenges
{
    public class SolveMeFirst
    {
        public static void Solve()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }


        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }

    }
}
