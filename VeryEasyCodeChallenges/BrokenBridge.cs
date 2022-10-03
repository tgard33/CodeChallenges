using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class BrokenBridge
    {
        public static bool IsSafeBridge(string str)
        {
            if (str.Contains(" "))
                return false;
            return true;
        }
    }
}
