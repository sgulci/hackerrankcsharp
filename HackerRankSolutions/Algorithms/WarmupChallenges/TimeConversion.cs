using System;

namespace WarmupChallenges
{
    public class TimeConversion
    {
        public static void Solve()
        {
            string initialTime = Console.ReadLine();

            solution(initialTime);
        }


        static void solution(string time)
        {
            string res = "";

            string[] timeArr = time.Substring(0, 8).Split(':');
            string checkPM = time.Substring(time.Length - 2);

            if (checkPM == "PM" && timeArr[0] != "12")
            {
                timeArr[0] = (Convert.ToInt16(timeArr[0]) + 12).ToString();
            }
            else if (checkPM == "AM" && timeArr[0] == "12")
            {
                timeArr[0] = "00";
            }

            res = string.Join(":", timeArr);

            Console.WriteLine(res);

        }
    }
}
