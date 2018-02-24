using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var studentsGrades = new List<Student>();
            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var currentStudent = new Student();
                currentStudent.Name = input[0];
                currentStudent.Grades = new List<double>();
                for (int j = 1; j < input.Length; j++)
                {
                    currentStudent.Grades.Add(double.Parse(input[j]));
                }
                studentsGrades.Add(currentStudent);
            }
            foreach (var student in studentsGrades.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade))
            {
                if (student.AverageGrade >= 5)
                {
                    Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
                }
            }

        }

        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade
            {
                get { return Grades.Average();  }
            }


        }
    }
}
