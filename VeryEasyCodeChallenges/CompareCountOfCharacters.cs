using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class CompareCountOfCharacters
    {
        public static bool compareCountOfCharacters(string one, string two)
        { 
            if(one.Length == two.Length)
                return true;
            else
                return false;
        }
    }
}
