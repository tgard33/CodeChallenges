using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class ContainsGivenNum
    {
        public static bool itContains(int[] arr, int item)
        {
            if (arr.Contains(item))
                return true;
            return false;
        }
    }
}
