using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitCodePractice.VeryEasyCodeChallenges
{
    internal class SumResistanceSeriesCircuits
    {
        public static string SeriesResistance(double[] arr)
        {
            var results = arr.Sum();

            if (results <= 1)
            {
                return $"{results} ohm";
            }
            else
                return $"{results} ohms";

            // Possibly better solution
            //double sum = arr.Sum();
            //return sum + (sum > 1 ? " ohms" : " ohm");
        }
    }
}
