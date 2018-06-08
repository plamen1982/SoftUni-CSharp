using System;

namespace _3.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();

            while (true)
            {
                var resources = Console.ReadLine();
                if (resources == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (resourceQuantity.ContainsKey(resources))
                {
                    resourceQuantity[resources] += quantity;
                }
                else
                {
                    resourceQuantity[resources] = quantity;
                }
            }

            foreach (KeyValuePair<string, int> item in resourceQuantity)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
