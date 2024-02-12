using System;
namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;

            int stepsDone = 0;

            bool walking = true;

            while (walking)
            {
                string steps = "";
                steps = Console.ReadLine();

                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    stepsDone += int.Parse(steps);
                    break;
                }

                int intSteps = int.Parse(steps);

                stepsDone += intSteps;


                if (stepsDone >= goal)
                {

                    walking = false;
                    break;
                }

            }

            if (stepsDone >= goal)
            {

                stepsDone = stepsDone - goal;
                stepsDone = Math.Abs(stepsDone);
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsDone} steps over the goal!");
                return;

            }
            else
            {

                stepsDone = stepsDone - goal;
                stepsDone = Math.Abs(stepsDone);
                Console.WriteLine($"{stepsDone} more steps to reach goal.");
                return;

            }

        }
    }
}