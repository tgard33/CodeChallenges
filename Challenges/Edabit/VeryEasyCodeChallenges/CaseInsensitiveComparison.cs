using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class CaseInsensitiveComparison
    {
        public static bool Compare(string one, string two)
        {
            if (one.Equals(two, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;

        }
    }
}
