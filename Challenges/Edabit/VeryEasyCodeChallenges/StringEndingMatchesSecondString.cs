using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class StringEndingMatchesSecondString
    {
        public static bool StringMatch(string str1, string str2)
        {
            if (str1.EndsWith(str2) || str2.EndsWith(str1))
            {
                return true;
            }
            else return false;

            // better way to do it with LINQ
            //return str1.EndsWith(str2);
        }
    }
}
