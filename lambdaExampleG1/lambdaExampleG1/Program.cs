using System;
using System.Collections.Generic;
using System.Linq;

namespace lambdaExampleG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>
            {
                new student {name = "Alice", grade = 85},
                new student {name = "Bob", grade = 76},
                new student {name = "Jacob", grade = 90},
                new student {name = "Tyler", grade = 55},
            };

            //1. Filter the studnts who passed
            var passedStudents = students.Where(s => s.grade >= 50);
            Console.WriteLine("Students who passed: ");
            foreach (var s in passedStudents) 
            {
                Console.WriteLine($"{s.name} - {s.grade}");
            }
            //2. Sort students by grade(descending)
            var sortedStudents = students.OrderByDescending(s => s.grade);

            Console.WriteLine("\nStudents sorted by grade: ");
            foreach(var s in sortedStudents)
            {
                Console.WriteLine($"{s.name} - {s.grade}");
            }

            //3. Only students names 
            var names = students.Select(s => s.name);
            Console.WriteLine("\nStudent names: ");
            foreach ( var name in names)
            {
                Console.WriteLine(name);
            }


            //4. find a specific student
            var topStudent = students.FirstOrDefault(s => s.grade >= 90);

            Console.WriteLine("\nTop student: ");

            if (topStudent != null)
            {
                Console.WriteLine($"{topStudent.name} - {topStudent.grade}");
            }


            //(Parameters) => expression_or_statement

            //Examples
            //Single parameters
            //x => x * 2

            //Multiple parameters
            //(x, y) => x + y;

            //no parameters
            //() => Console.writeline("hello world");

            //Multiple statements
            //(x) =>
            //{
            //      int resulte = x*2;
            //      return result;
            //};

            //with collections LINQ
            // int[] numbers = {1,2,3,4,5};
            //var evenNumbers = numbers.Where(x=> x % 2 == 0);
        }
    }
}
