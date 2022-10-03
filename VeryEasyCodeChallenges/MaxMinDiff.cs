using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class MaxMinDiff
    {
        public static int difference(int[] arr)
        {
           int result = arr.Max() - arr.Min();
            return result;
        }
    }
}
