using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    internal class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        Dog dog { get; set; }

        public Person(string name , int age , Dog dog) 
        {
            this.name = name;
            this.age = age;
            this.dog = dog;
        }
        

    }
}
