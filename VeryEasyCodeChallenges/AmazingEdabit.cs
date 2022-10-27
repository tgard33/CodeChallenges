using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class AmazingEdabit
    {
        public static string amazingEdabit(string str)
        {
            if (str.Contains("edabit"))
                return str;
            else if (str.Contains("amazing"))
                return str.Replace("amazing", "not amazing");
            else
                return "String does not contain the word edabit or amazing";
        }
    }
}
