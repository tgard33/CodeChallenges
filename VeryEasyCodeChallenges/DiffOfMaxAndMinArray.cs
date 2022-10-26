using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class DiffOfMaxAndMinArray
    {
        public static int DiffMaxMin(int[] arr)
        {
            return arr.Max() - arr.Min();
        }
    }
}
