using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class Teacher : IPerson
    {
        public string name { get; set; }
        public int age { get; set; }
        public string subject { get; set; }

        public Teacher(string name, int age, string subject)
        {
            this.name = name;
            this.age = age;
            this.subject = subject;
        }

        public string RDetails()
        {
            return $"Name: {name}, Age: {age}, Subject: {subject}"; 
        }

        public string GetPersonType()
        {
            return "Teacher";
        }
    }
}
