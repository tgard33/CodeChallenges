using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class AddStringEndingToArray
    {
        public static string[] AddToEnd(string[] arr, string ending)
        {
            return arr.Select(x => x + ending).ToArray();
        }
    }
}
