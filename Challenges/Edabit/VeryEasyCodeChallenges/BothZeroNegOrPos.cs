using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class BothZeroNegOrPos
    {
        public static bool zeroNegOrPos(int x, int y)
        {
            if (x < 0 && y < 0 || x > 0 && y > 0 || x == 0 && y == 0)
                return true;
            return false;
        }
    }
}
