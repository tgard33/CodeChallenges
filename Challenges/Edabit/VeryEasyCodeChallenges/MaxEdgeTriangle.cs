using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class MaxEdgeTriangle
    {
        public static int MaxEdge(int side1, int side2)
        {
            int MaxEdgeRange = side1 + side2 - 1;
            return MaxEdgeRange;
        }
    }
}
