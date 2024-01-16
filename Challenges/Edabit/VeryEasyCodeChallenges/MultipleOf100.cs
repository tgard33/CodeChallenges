using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class MultipleOf100
    {
        public static bool multipleOf100(int x)
        {
            if (x % 100 == 0)
                return true;
            else return false;
        }
    }
}
