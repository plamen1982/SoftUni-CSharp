using System;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(name: "Pesho", age: 29);
            Person person1 = new Person();

            Console.WriteLine(person.getName());

        }
    }
}
