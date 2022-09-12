using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class ReturnNegative
    {
        public static int returnNegative(int n)
        {
            //First Solution

            //if (n % 2 == 0 && n >= 0)
            //    return (n * -1);
            //else if (n >= 0)
            //    return (n * -1);
            //else
            //    return n;

            //Better Solution
            if (n < 0)
                return n;
            else
                return -n;


        }
    }
}
