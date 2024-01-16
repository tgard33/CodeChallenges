using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class MissingThirdAngle
    {
        public static string MissingAngle(int angle1, int angle2)
        {
            if (180 - (angle1 + angle2) > 90 && 180 - (angle1 + angle2) <= 180)
            {
                return "obtuse";
            }
            else if (180 - (angle1 + angle2) == 90)
            {
                return "right";
            }
            else
                return "acute";

            // Better way to do it
            //var angleSum = angle1 + angle2;

            //if (angleSum != 90)
            //{
            //    return angleSum > 90 ? "acute" : "obtuse";
            //}

            //return "right";
        }
    }
}
