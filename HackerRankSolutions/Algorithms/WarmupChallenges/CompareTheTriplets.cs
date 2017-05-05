using System;
using System.Collections.Generic;

namespace WarmupChallenges
{
    public class CompareTheTriplets
    {

        public static void Solve()
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            string[] tokens_b0 = Console.ReadLine().Split(' ');

            int[] result = solution(tokens_a0, tokens_b0);

            Console.WriteLine(String.Join(" ", result));
        }


        static int[] solution(string[] aliceNumbers , string[] bobNumbers)
        {
            
            List<int> result = new List<int>();

            int AliceScore = 0;
            int BobScore = 0;

            for (int i = 0; i < 3; i++)
            {
                if (Convert.ToInt32(aliceNumbers[i]) > Convert.ToInt32(bobNumbers[i]))
                {
                    AliceScore++;
                }
                else if (Convert.ToInt32(aliceNumbers[i]) < Convert.ToInt32(bobNumbers[i]))
                {
                    BobScore++;
                }
            }

            result.Add(AliceScore);
            result.Add(BobScore);

            return result.ToArray();
        }
        
    }
}
