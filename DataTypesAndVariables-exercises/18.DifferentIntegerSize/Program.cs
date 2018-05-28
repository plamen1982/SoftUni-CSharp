using System;


namespace _18.DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {


            /* First Solution
             
            string n = Console.ReadLine();
            string message = "";
            try
            {
                sbyte sbyteType = sbyte.Parse(n);
                message += "* sbyte" + Environment.NewLine;
            }

            catch (Exception)
            {

            }

            try
            {
                byte byteType = byte.Parse(n);
                message += "* byte" + Environment.NewLine;

            }

            catch (Exception)
            {

            }

            try
            {
                short shortType = short.Parse(n);
                message += "* short" + Environment.NewLine;


            }
            catch (Exception)
            {

            }

            try
            {
                ushort ushortType= ushort.Parse(n);
                message += "* ushort" + Environment.NewLine;

            }
            catch (Exception)
            {

            }

            try
            {
                int intType = int.Parse(n);
                message += "* int" + Environment.NewLine;

            }
            catch (Exception)
            {

            }

            try
            {
                uint uintType = uint.Parse(n);
                message += "* uint" + Environment.NewLine;
            }
            catch (Exception)
            {

            }

            try
            {
                long intType = long.Parse(n);
                message += "* long" + Environment.NewLine;


            }
            catch (Exception)
            {

                Console.WriteLine($"{n} can\'t fit in any type");

            }

            if (message.Length != 0)
            {
                Console.WriteLine($"{n} can fit in: ");
                Console.WriteLine(message);
            }

            */

            /*Second Solution */
            string message = "";
            string input = Console.ReadLine();
            try
            {
                long n = long.Parse(input);

                if (n <= sbyte.MaxValue && n >= sbyte.MinValue)
                {
                    message += "* sbyte" + Environment.NewLine;
                }

                if (n <= byte.MaxValue && n >= byte.MinValue)
                {
                    message += "* byte" + Environment.NewLine;

                }

                if (n <= short.MaxValue && n >= short.MinValue)
                {
                    message += "* short" + Environment.NewLine;

                }

                if (n <= ushort.MaxValue && n >= ushort.MinValue)
                {
                    message += "* ushort" + Environment.NewLine;

                }
                if (n <= int.MaxValue && n >= int.MinValue)
                {
                    message += "* int" + Environment.NewLine;

                }
                if (n <= uint.MaxValue && n >= uint.MinValue)
                {
                    message += "* uint" + Environment.NewLine;

                }
                if (n <= long.MaxValue && n >= long.MinValue)
                {
                    message += "* long" + Environment.NewLine;

                }
                if (message.Length != 0)
                {
                    Console.WriteLine($"{n} can fit in: ");
                    Console.WriteLine($"{message}");
                }
            }
            catch (Exception)
            {

             Console.WriteLine($"{input} can\'t fit in any type");

            }

        }
    }
}
