using System;
using System.Collections.Generic;

namespace Implementation
{
    public class GradingStudents
    {
        public void Solve()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];

            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] result = solve(grades);

            Console.WriteLine(String.Join("\n", result));

        }

        static int[] solve(int[] grades)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < grades.Length; i++)
            {
                int rem = 0;

                Math.DivRem(grades[i], 5, out rem);

                if (grades[i] < 38 || rem < 3)
                {
                    res.Add(grades[i]);
                }
                else
                {
                    res.Add(grades[i] + (5 - rem));
                }
            }

            return res.ToArray();
        }
    }
}
