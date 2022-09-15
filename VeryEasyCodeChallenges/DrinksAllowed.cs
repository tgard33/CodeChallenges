using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class DrinksAllowed
    {
        public static bool ShouldServeDrinks(int age, bool on_break)
        {
            if (age >= 18 && on_break == false)
                return true;
            else
                return false;
        }
    }
}
