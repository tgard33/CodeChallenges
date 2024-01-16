using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class VoltageAndCurrentToPower
    {
        public static int CircuitPower(int voltage, int current)
        {
            int power = voltage * current;
            return power;
        }
    }
}
