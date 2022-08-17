using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class TheFarmProblem
    {
        public static int FarmAnimals(int chicken, int cow, int pig)
        {
            chicken = chicken * 2;
            pig = pig * 4;
            cow = cow * 4;
            return chicken + cow + pig;
        }
    }
}
