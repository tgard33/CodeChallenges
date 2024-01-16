using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class HoursToSec
    {
        public static int howManySeconds(int hours)
        {
            int hoursInSeconds = hours * 60 * 60;
            return hoursInSeconds;
        }
    }
}
