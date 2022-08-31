using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class DividesEvenly
    {
        public static bool evenlyDivides(int a, int b)
        {
            int result = a / b;
            if (a % b == 0)
                return true;
            else
                return false;
        }
    }
}
