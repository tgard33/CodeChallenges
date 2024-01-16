using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class IsStringEmpty
    {
        public static bool isStringEmpty(string str)
        {
            if (str.Length == 0)
                return true;
            else
                return false;
        }
    }
}
