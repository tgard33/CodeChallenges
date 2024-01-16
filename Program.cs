using EdabitCodePractice.ConsoleDisplayLogic;

namespace program
{
    public static class Program
    { 
        static void Main(string[] args) 
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to Tyler Gardners code practice console app!\n");
                Console.WriteLine("Which code challenge solutions do you want to see?\n");
                Console.WriteLine("1. Edabit Code Practice Solutions");
                Console.WriteLine("2. Interview Code Challenge Solutions");
                Console.WriteLine("3. I don't care about code challenges, show me something coool!");
                Console.WriteLine("4. Exit\n");

                int choice;
                while (true)
                {
                    Console.Write("Enter your choice (1, 2, 3, or 4): ");
                    if (int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2 || choice == 3 || choice == 4))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number from 1 - 3.");
                    }
                }

                switch (choice)
                {
                    case 1:
                        EdabitSolutionsDisplay.EdabitSolutions();
                        break;
                    case 2:
                        InterviewCodeSolutionsDisplay.InterviewCodeSolutions();
                        break;
                    case 3:
                        CoolStuffDisplay.CoolStuffSolutions();
                        break;
                    case 4:
                        exit = true;
                        break;
                }

                //Console.WriteLine($" {}.\n");
            }

        }

    }
}
