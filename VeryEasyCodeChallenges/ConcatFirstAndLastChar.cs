using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class ConcatFirstAndLastChar
    {
        public static string concatFirstAndLast(string str)
        {
            return $"{str.First()}{str.Last()}";

            //Another way to do it from Edabit soluitons
            //return string.Concat(str.First(), str.Last());
        }
    }
}
