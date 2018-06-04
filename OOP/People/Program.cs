using System;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Human gosho = new Human("Gosho", "Iliev");
            Student plamen = new Student("Plamen", "Hristov", 6);
            Worker peter = new Worker("Peter", "Ivanov", 50, 8);

            Console.WriteLine($"Good job Peter, today you made: {peter.calculateMoney()}lv.");
            Console.WriteLine($"Great job Plamen! Your grade from C# is: {plamen.Grade} Nice!");
            Console.WriteLine($"Last name of {gosho.FirstName} is: {gosho.LastName}");

        }
    }
}
