using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.Challenges.Edabit.VeryEasyCodeChallenges
{
    internal class AddStringEndingToArray
    {
        public static string[] AddToEnd(string[] arr, string ending)
        {
            return arr.Select(x => x + ending).ToArray();
        }
    }
}
