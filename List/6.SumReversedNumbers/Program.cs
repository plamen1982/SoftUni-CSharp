﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "Brachiosaurus",
                           "Amargasaurus",
                           "Mamenchisaurus" };

            List<string> dinosaurs = new List<string>(input);

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nAddRange(dinosaurs)");
            dinosaurs.AddRange(dinosaurs);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nRemoveRange(2, 2)");
            dinosaurs.RemoveRange(2, 2);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            input = new string[] { "Tyrannosaurus",
                               "Deinonychus",
                               "Velociraptor"};

            Console.WriteLine("\nInsertRange(3, input)");
            dinosaurs.InsertRange(3, input);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\noutput = dinosaurs.GetRange(2, 3).ToArray()");
            string[] output = dinosaurs.GetRange(2, 3).ToArray();

            Console.WriteLine();
            foreach (string dinosaur in output)
            {
                Console.WriteLine(dinosaur);
            }
        }
    }
}
