using EdabitCodePractice.CodeChallenges;
using System;
using System.Collections.Generic;

namespace program
{
    public static class Program
    { 
        static void Main(string[] args) 
        { 
            Console.WriteLine("Hello, World!\n\nBelow are the results of each code challenge.\n");

            Console.WriteLine($"Is Edabit Code Challenges working?\n{HowEdabitWorks.ReturnTrue()}.\n");

            Console.WriteLine($"The sum of 5 + 3 = {ReturnSumOfTwoNumbers.Sum(5, 3)}.\n");

            Console.WriteLine($"60 minutes converted to seconds = {ConvertMinToSeconds.convert(60)} seconds.\n");

            Console.WriteLine($"After 2 comes {ReturnNextNumberFromIntPassed.Addition(2)}.\n");

            Console.WriteLine($"If the circuit power has a voltage of 110 and a current of 3 it has {VoltageAndCurrentToPower.CircuitPower(110, 3)} power.");
        }
    }
}
