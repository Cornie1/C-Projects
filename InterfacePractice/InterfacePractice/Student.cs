using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class Student : IPerson
    {
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }
        public Student(string name, int age, int grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public string RDetails()
        {
            return $"Name: {name}, Age: {age}, Grade: {grade}";
        }
        public string GetPersonType()
        {
            return "Student";
        }
    }
}
