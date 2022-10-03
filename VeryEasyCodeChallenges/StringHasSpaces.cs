using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class StringHasSpaces
    {
        public static bool stringHasSpaces(string str)
        { 
            if (str.Contains(" "))
                return true;
            return false;
        }
    }
}
