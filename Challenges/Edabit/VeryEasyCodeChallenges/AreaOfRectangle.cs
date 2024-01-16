using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class AreaOfRectangle
    {
        public static int areaOfRectangle(int length, int width)
        {
            int area = length * width;
            if (length <= 0 || width <= 0)
                return -1;
            else return area;
        }
    }
}
