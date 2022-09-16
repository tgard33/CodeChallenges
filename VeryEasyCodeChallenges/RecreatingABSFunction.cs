using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class RecreatingABSFunction
    {
        public static int absolute(int num)
        {
            if (num >= 0)
                return num;
            else
                return num * -1;
        }
    }
}
