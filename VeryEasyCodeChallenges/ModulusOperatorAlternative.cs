using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class ModulusOperatorAlternative
    {
        public static int Mod(int a, int b)
        {
            return (a - b * (a / b));
        }
    }
}
