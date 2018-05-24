using System;

namespace _8.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            char gender = Convert.ToChar(Console.ReadLine());
            long id= Convert.ToInt64(Console.ReadLine());
            int uniqueNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + id);
            Console.WriteLine("Unique Employee number: " + uniqueNumber);

        }
    }
}
