namespace _08.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade => Grades.Average();
    }

    class Program
    {
        static void Main()
        {
            string[] inputArray = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            int n = int.Parse(inputArray[0]);
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                string[] inputArgs = inputArray[i + 1].Split(' ');

                student.Name = inputArgs[0];
                student.Grades = inputArgs.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }

            students
                .Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s => File.AppendAllText(
                    "output.txt", $"{s.Name} -> {s.AverageGrade:F2}" + Environment.NewLine));
        }
    }
}
