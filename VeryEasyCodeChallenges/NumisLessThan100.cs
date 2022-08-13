using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.CodeChallenges
{
    internal class NumisLessThan100
    {
        public static bool lessThan100(int x, int y)
        {
            if (x + y < 100)
                return true;
            else
                return false;
        }
    }
}
