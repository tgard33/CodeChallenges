using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class LastCharacterN
    {
        public static bool isLastCharacterN(string word)
        {
            if (word.EndsWith("n") || word.EndsWith("N"))
                return true;
            return false;
        }
    }
}
