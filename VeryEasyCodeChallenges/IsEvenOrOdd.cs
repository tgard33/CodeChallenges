using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class IsEvenOrOdd
    {
        public static string isEvenOrOdd(int num)
        {
            if (num % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
    }
}
