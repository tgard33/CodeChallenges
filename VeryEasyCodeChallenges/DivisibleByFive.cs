using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class DivisibleByFive
    {
        public static bool divisibleByFive(int integer)
        {
            if (integer % 5 == 0)
                return true;
            else
                return false;
        }
    }
}
