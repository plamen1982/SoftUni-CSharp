﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;

            }
            Console.WriteLine(sum);
            Console.Write(sum.GetType());
        }
    }
}
