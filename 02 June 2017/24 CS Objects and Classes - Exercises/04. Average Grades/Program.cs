using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade => this.Grades.Average();
        }

        static void Main(string[] args)
        {
            var students = new List<Student>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];
                var grades = input.Skip(1).Select(double.Parse).ToList();

                var studentData = new Student { Name = name, Grades = grades };

                students.Add(studentData);
            }

            students = students
                .Where(a => a.AverageGrade >= 5.00)
                .OrderBy(a => a.Name)
                .ThenByDescending(a => a.AverageGrade)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}
