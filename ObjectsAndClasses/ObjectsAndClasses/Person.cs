using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsAndClasses
{
    class Person
    {
        private string name;
        private int age;



        public string getName()
        {
            return this.name;
        }

        public void setName(string nameInput)
        {
            this.name = nameInput;
        }

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public Person()
        {
            //default constructor
        }

    }
}
