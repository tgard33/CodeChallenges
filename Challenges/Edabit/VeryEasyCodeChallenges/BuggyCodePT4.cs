using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class BuggyCodePT4
    {
        public static string greeting(string name)
        {
            if (name == "Mubashir")
                return "Hello, my Love!";
            else
                return $"Hello, {name}!";
        }
    }
}
