using System;

namespace _1.BlankReceipt
{
    class Program
    {
        static void Header()
        {
            Console.WriteLine($"CASH RECEIPT{Environment.NewLine}------------------------------");
        }
        static void Body()
        {
            Console.WriteLine($"Charged to____________________{Environment.NewLine}Received by___________________");
        }
        static void Footer()
        {
            Console.WriteLine($"------------------------------{Environment.NewLine}© SoftUni");
        }
        static void Main(string[] args)
        {
            Header();
            Body();
            Footer();
        }
    }
}
