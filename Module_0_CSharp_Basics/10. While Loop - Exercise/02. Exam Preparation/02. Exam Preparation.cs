using System;
using System.Runtime.CompilerServices;
namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {

            int faledThredhold = int.Parse(Console.ReadLine());


            //a.брояч за незадоволителни оценки
            int failedTimes = 0;
            //b.брояч за решените упражнения
            int solvedProblemsCont = 0;
            //c.сумата на всички оценки
            double gradeSum = 0;
            //d.коя е последната задача
            string lastProblem = "";
            //e.дали се е провалил или не
            bool isFailed = true;

            while (failedTimes < faledThredhold)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedProblemsCont++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {faledThredhold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / solvedProblemsCont:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCont}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

        }
    }
}