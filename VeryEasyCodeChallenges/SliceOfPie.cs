using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class SliceOfPie
    {
        public static bool EqualSlices(int totalSlices, int eaters, int slicesPerEater)
        { 
            if (eaters * slicesPerEater > totalSlices)
                return false;
            return true;
        }
    }
}
