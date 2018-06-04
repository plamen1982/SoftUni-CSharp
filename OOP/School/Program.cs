using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            People peter = new People("Peter");
            Students plamen = new Students("Plamen", 7222);
            Teachers mihail = new Teachers("Mihail", "C#");
            Subjects cSharp = new Subjects("C#", 31571, 15);

            Console.WriteLine($"Name: {peter.Name}");
            Console.WriteLine($"Student: {plamen.Name}, Id: {plamen.Id}");
            Console.WriteLine($"Teacher: {mihail.Name}, Subject: {mihail.Subject}" );
            Console.WriteLine($"Subject: {cSharp.NameSubject}, Number of exercises: {cSharp.NumberOfExersices}, Number of hours: {cSharp.NumberOfHours}");
        }

    }
}
