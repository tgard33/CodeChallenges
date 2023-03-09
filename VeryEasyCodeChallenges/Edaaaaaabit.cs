using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    public class Edaaaaaabit
    {
        public static string Edaabit(int n)
        {
            string s = string.Empty;

            if (n < 0)
                return string.Empty;
            if (n == 0)
                return "Edbit";

            for (int i = 0; i < n - 1; i++)
                s += "a";
            string fs = "Ed" + s + "abit";
            return fs;
        }
    }
}
