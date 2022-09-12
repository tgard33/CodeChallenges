using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class StringOddOrEven
    {
        public static bool stringOddOrEven(string word)
        { 
            int stringLength = word.Length;
            if (stringLength % 2 == 0)
                return true;
            else 
                return false;
        }
    }
}
