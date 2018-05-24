using System;

namespace _18.DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {

            string n = Console.ReadLine();
            string message = "";
            try
            {
                sbyte sbyteType = sbyte.Parse(n);
                message = "* sbyte";
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                sbyte sbyteType = sbyte.Parse(n);
                message = "* sbyte";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
