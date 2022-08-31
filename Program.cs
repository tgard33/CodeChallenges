using EdabitCodePractice.CodeChallenges;
using EdabitCodePractice.VeryEasyCodeChallenges;
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

            Console.WriteLine($"If the circuit power has a voltage of 110 and a current of 3 it has {VoltageAndCurrentToPower.CircuitPower(110, 3)} power.\n");

            Console.WriteLine($"The opposite of the boolean value True, is {FlipTheBoolean.Reverse(true)}.\n");

            Console.WriteLine($"The age 25 converted to days = {ConvertAgeToDays.CalcAge(25)}.\n");
            
            Console.WriteLine($"The area of a triangle with a base of 7 and height of 4 = {AreaOfTriangle.triArea(7,4)}.\n");

            Console.WriteLine($"The remainder of two number (-9 and 45) = {RemaindersOfTwoNum.Remainder(-9,45)}.\n");

            Console.WriteLine($"Is 10 less than or equal to 0?\n{NumberLessThanEqualToZero.LessThanOrEqualToZero(10)}.\n");

            Console.WriteLine($"Is 23 + 76 less than 100?\n{NumisLessThan100.lessThan100(23,76)}.\n");

            Console.WriteLine($"Are 100 and 10 equal?\n{AreNumbersEqual.equalNumbers(100,10)}.\n");

            Console.WriteLine($"{ReturnSomethingToMe.something("is working")}.\n");

            Console.WriteLine($"24 hours is equal to {HoursToSec.howManySeconds(24)} seconds.\n");

            Console.WriteLine($"The sum of internal angles of a 3-sided polygon equals {SumOfPolygonAngles.PolygonSum(3)}.\n");
            
            Console.WriteLine($"Concate Mubashir with Edabit = {BasicVariableAssignment.addEdabit("Mubashir")}.\n");

            Console.WriteLine($"If a is false and b is true = {UsingANDANDOperator.AndOperator(false, true)}.\n");

            Console.WriteLine($"I made 3 Two Pointers and 5 Three Pointers. I scored a total of {BasketballPoints.points(3,5)} points.\n");

            Console.WriteLine($"The Perimeter of a rectangle with length 6 and width 4 is {RectanglePerimeter.Perimeter(6,4)}.\n");

            Console.WriteLine($"{NameGreeting.Greeting("Tyler")}.\n");

            Console.WriteLine($"I have 2 chickens, 3 cows, and 5 pigs. How many legs do all my animals have combined? {TheFarmProblem.FarmAnimals(2,3,5)}.\n");

            Console.WriteLine($"In Fantasy Football I have 2 wins, 3 draws, and 1 loss. How many points do I have? {FootballPoints.totalPoints(2,3,1)}.\n");

            //Fix me TG
            //Console.WriteLine($"What is the first element in the array 5, 6, 7? {Return1stElementInArray.GetFirstValue(objec])}.\n");

            Console.WriteLine($"By converting 12 hours to seconds and 75 minutes to seconds you get a total of {HoursAndMinToSeconds.ConvertingHoursAndSeconds(12, 75)} seconds.\n");

            Console.WriteLine($"Buggy code part 4 outputs Hello + Name unless the name is Mubashir. This is what it outputs for Mubashir: {BuggyCodePT4.greeting("Mubashir")}.\n");

            Console.WriteLine($"The maximum range of a triangles third edge with sides that are 8 and 10 inches long is {MaxEdgeTriangle.MaxEdge(8, 10)} inches.\n");

            Console.WriteLine($"324 inches converted to feet = {InchesToFeet.inchesToFeet(324)}.\n");

            Console.WriteLine($"Is 37 divisible by 5? {DivisibleByFive.divisibleByFive(37)}.\n");

            Console.WriteLine($"Flip integer bool if it is 1 it returns {FlipIntegerBoolean.flipIntegerBool(1)}.\n");

            Console.WriteLine($"Does 98 divide by 7 evenly? {DividesEvenly.evenlyDivides(98, 7)}.\n");

            //Console.WriteLine($" {}.\n");
            //Console.WriteLine($" {}.\n");
            //Console.WriteLine($" {}.\n");

        }
    }
}
