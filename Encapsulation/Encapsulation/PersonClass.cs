using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class PersonClass
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string degree { get; set; }


        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        public PersonClass(string name, string surname, int age, string degree)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.degree = degree;
        }
        
        public PersonClass() 
        {
            
        }
        
        public string display()
        {
            return name + " " + surname + " " + age + " Years old and is studying" + degree;
        }
            
    }
}
