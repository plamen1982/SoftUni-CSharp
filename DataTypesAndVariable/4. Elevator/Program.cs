using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            int capacityPeople = int.Parse(Console.ReadLine());

            if (capacityPeople > people)
            {
                Console.WriteLine(1);
            }
            else
            {
                int course = (int)Math.Ceiling((double)people / capacityPeople);
                Console.WriteLine(course);

            }
        }
    }
}
