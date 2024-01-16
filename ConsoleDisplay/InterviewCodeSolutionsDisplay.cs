using EdabitCodePractice.Challenges.Interviews.InterviewCodeChallenges;

namespace EdabitCodePractice.ConsoleDisplayLogic
{
    internal class InterviewCodeSolutionsDisplay
    {
        public static void InterviewCodeSolutions()
        {
            Console.WriteLine("\nHello, World!\n\nBelow are the results of each interview code challenge.\n");

            Console.WriteLine($"If a version number is the same it returns 0. If version 1 is bigger than it returns 1. " +
                $"If Version 2 is bigger it returns -1. If version 1 is 2 and version 2 is 2.0.0.0 it should return 0. " +
                $"Here is what it returns with those values: {VersionComparisonEvaluator.VersionCompare("2", "2.0.0.0")}");
        }
    }
}
