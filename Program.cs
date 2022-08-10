using EdabitCodePractice.CodeChallenges;
using System;
using System.Collections.Generic;

namespace program
{
    public static class Program
    { 
        static void Main(string[] args) 
        { 
            Console.WriteLine("Hello, World!");

            Console.WriteLine($"Is Edabit Code Challenges working? {HowEdabitWorks.ReturnTrue()}.");

            Console.WriteLine($"The sum of 5 + 3 equals {ReturnSumOfTwoNumbers.Sum(5, 3)}.");

            Console.WriteLine($"60 minutes converted to seconds equals {ConvertMinToSeconds.convert(60)} seconds.");
        }
    }
}
