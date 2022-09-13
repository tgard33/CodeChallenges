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
            int oneCount = one.Length;
            int twoCount = two.Length;
            if(oneCount == twoCount)
                return true;
            else
                return false;
        }
    }
}
