using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal Bob = new Mammal(25);
            Dog George = new Dog(40, "Shepard");
            Cat Missi = new Cat(27, "Myaaau");

            Console.WriteLine($"Bob is {Bob.Age} years old");
            Console.WriteLine($"George is {George.Age} years old and he is a {George.Breed} breed.");
            George.WagTail();
            Console.WriteLine($"Missi is {Missi.Age} years old and she like to say {Missi.Myau} ;)");
            int five = 5;

            if (!(five is string))
            {
                Console.WriteLine(five);
            }
        }
    }
}
