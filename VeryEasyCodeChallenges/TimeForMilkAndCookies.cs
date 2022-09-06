using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class TimeForMilkAndCookies
    {
        public static bool timeForMilkAndCookies(int year, int month, int day)
        {
            if (month == 12 && day == 24)
                return true;
            else return false;
        }
    }
}
