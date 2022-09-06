using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class ProfitableGamble
    {
         public static bool profitableGamble (double prob, double prize, double pay)
            {
                if (prob * prize > pay)
                    return true;
                else return false;
            }
    }

}
