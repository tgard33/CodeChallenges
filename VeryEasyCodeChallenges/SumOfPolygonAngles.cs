using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class SumOfPolygonAngles
    {
        public static int PolygonSum(int num)
        {
            int angleSum = (num - 2) * 180;
            return angleSum;
        }
    }
}
