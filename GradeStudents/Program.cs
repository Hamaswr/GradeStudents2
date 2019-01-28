using System;
using System.Collections.Generic;

namespace GradeStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades g = new Grades();
            g.AddGrade(95);
            g.AddGrade(85);
            g.AddGrade(90);

            var grades = g.grades2;

            float sum = 0;

            foreach (var grade in grades)
            {
                sum += grade;
            }

            var avg = sum / grades.Count;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {avg}");
        }
    }
}
