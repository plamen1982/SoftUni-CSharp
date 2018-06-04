using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Mammal
    {
        public int Age { get; set; }

        public Mammal(int age)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping :)");
        }
    }
}
