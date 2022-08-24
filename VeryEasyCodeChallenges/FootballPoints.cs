using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class FootballPoints
    {
        public static int totalPoints(int wins, int draws, int losses)
        {
            int winsCount = 3 * wins;
            int drawsCount= 1 * draws;
            int lossesCount = 0;
            int totalPoints = winsCount + drawsCount + lossesCount;
            return totalPoints;
        }
    }
}
