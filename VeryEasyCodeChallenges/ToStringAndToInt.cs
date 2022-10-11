using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class ToStringAndToInt
    {
        public static string ToString(int x)
        { 
            return x.ToString();
        }

        public static int ToInt(string str)
        { 
            return int.Parse(str);
        }
    }
}
