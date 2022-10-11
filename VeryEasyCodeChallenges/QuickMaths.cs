using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class QuickMaths
    {
        public static string quickMaths(int x, int y)
        {
            if (x * y == 24)
                return "Multiply";
            else if (x + y == 24)
                return "Add";
            else if (x - y == 24)
                return "Subtract";
            else if (x / y == 24)
                return "Divide";
            else
                return "None";
        }
    }
}
