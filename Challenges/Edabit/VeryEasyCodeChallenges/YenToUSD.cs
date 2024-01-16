using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class YenToUSD
    {
        public static double yenToUsd(int yen)
        {
            double result = yen / 107.5;
            return Math.Round(result, 2);

            // Simplified
            //return Math.Round(yen / 107.5, 2);
        }
    }
}
