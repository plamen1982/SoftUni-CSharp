using System;

namespace EmployeesData
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName = Console.ReadLine();
            int employeeAge = int.Parse(Console.ReadLine());
            int employeeId = int.Parse(Console.ReadLine());
            double employeeSalary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {employeeName}");
            Console.WriteLine($"Age: {employeeAge}");
            Console.WriteLine($"Employee ID: {employeeId:D8}");
            Console.WriteLine($"Salary: {employeeSalary:F2}");
        }
    }
}


