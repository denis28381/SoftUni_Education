namespace _6._Student_Academy
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new Student(studentName));
                }

                students[studentName].Grades.Add(grade);
            }

            var filteredStudents = students.Where(pair => pair.Value.Grades.Average() >= 4.50m);

            foreach (var studentPair in filteredStudents)
            {
                Console.WriteLine($"{studentPair.Value}");
            }
        }
    }

    class Student
    {
        public string Name;

        public List<decimal> Grades;
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }

        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():F2}";
        }
    }
}