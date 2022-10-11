using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class SingularOrPlural
    {
        public static bool IsPlural(string word)
        {
            if (word.EndsWith("s") || word.EndsWith("S"))
                return true;
            return false;
        }
    }
}
