namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {

            string[] line = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < line.Length; i++)
            {
                
                int lettersNumber = line[i].Where(char.IsLetter).Count();

                int puncruationMarks = line[i].Where(char.IsPunctuation).Count();

                line[i] = $"Line {i + 1}: {line[i]} ({lettersNumber})({puncruationMarks})";

                Console.WriteLine(line[i]);
            }

            File.WriteAllLines(outputFilePath, line);

        }
    }
}