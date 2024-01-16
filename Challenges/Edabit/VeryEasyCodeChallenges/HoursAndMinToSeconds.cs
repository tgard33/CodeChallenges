using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class HoursAndMinToSeconds
    {
        public static int ConvertingHoursAndSeconds(int hours, int minutes)
        {
            int hoursToSeconds = hours * 60 * 60;
            int minutesToSeconds = minutes * 60;
            return hoursToSeconds + minutesToSeconds;
        }
    }
}
