namespace EdabitCodePractice.InterviewCodeChallenges
{
    public class VersionComparisonEvaluator
    {
        public static int VersionCompare(string version1, string version2)
        {
            string[] parts1 = version1.Split('.');
            string[] parts2 = version2.Split('.');

            int length = Math.Max(parts1.Length, parts2.Length);


            for (int i = 0; i < length; i++)
            {
                int part1 = (i < parts1.Length) ? int.Parse(parts1[i]) : 0;
                int part2 = (i < parts2.Length) ? int.Parse(parts2[i]) : 0;

                if (part1 < part2)
                    return -1;
                if (part1 > part2)
                    return 1;
            }

            return 0;
        }
    }
}

//Instructions
//For this test, program an algorithm in C# to compare software versions stored in a custom version format as described below.
//You will be evaluated both on your algorithm correctly executing all of the test cases successfully and on the quality of your code.

//TIP: You may find it easier to program the algorithm in Visual Studio and then copy it into the code editor for running the tests.
//You are given up to 60 minutes to complete this test, but many will finish in 30 minutes or less.
//Custom version format
//Software versions are stored as a string which has 5 parts stored as the format [major]. [minor]. [patch].[build].[compilation].
//Each version part will always be non-negative integers. You may see versions like "2", "1.5", or "2.12.4.0.6".
//The period is only used as a separator and does not represent a decimal point (i.e. 1.5 does not mean one and a half.)

//Algorithm details
//Your algorithm should have two string input parameters: version 1 and version2. It should return -1 when version is less than
//version2, 0 when version1 = version2, and 1 when version 1 is

//greater than version2.

//All inputs can be treated as valid and the maximum version part will be less than 100.

//Examples

//Here are some examples showing how similar versions compare:

//﻿"2"=="2.0="2.0.0"=="2.0.0.0" =="2.0.0.0.0"（returns O in
//each case)
//﻿"2"<"2.0.0.0.1"（returns -1）
//﻿﻿"2" < "2.1" (returns -1)
//﻿﻿"2.1.0" > "2.0.1" (returns 1)
//﻿﻿"2.10.0.1" > "2.1.0.10" (returns 1)
//﻿"2.0.1"> "1.2000.1" （returns 1)
