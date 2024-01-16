using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class CalculateUsingString
    {
        public static int calculation(int num1, int num2, string operation)
        {
            if (operation == "+")
                return num1 + num2;
            else if (operation == "-")
                return num1 - num2;
            else if (operation == "*")
                return num1 * num2;
            else if (operation == "/")
                return num1 / num2;
            else if (operation == "%")
                return num1 / num2;
            else
                return 0;
        }
    }
}
