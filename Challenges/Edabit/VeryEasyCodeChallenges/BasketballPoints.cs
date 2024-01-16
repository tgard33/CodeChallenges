using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class BasketballPoints
    {
        public static int points(int twoPoints, int threePoints)
        {
            var TwoPointResult = twoPoints * 2;
            var ThreePointResult = threePoints * 3;
            return TwoPointResult + ThreePointResult;
        }
    }
}
