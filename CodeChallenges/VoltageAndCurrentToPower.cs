using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.CodeChallenges
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
