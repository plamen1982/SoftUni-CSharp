using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AndreyAndBilliard
{

    class Customer
    {

        public string Name { get; set; }
        public Dictionary<string, decimal> ProductsAndQuantities { get; set; }
        public decimal Check { get; set; } 

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            List<Customer> customers = new List<Customer>();

            while (n-- > 0)
            {
                string[] line = Console.ReadLine().Split('-');
                string product = line[0];
                decimal priceProduct = decimal.Parse(line[1]);
                products[product] = priceProduct;
            }


            while (true)
            {
                string[] line = Console.ReadLine().Split("-,".ToCharArray());
                string name = line[0];
                if (line[0] == "end of clients")
                {
                    break;
                }
                string product = line[1];
                int quantity = int.Parse(line[2]);

                if (products.ContainsKey(product))
                {
                    Customer customer = new Customer();
                    customer.Name = name;
                    customer.ProductsAndQuantities = new Dictionary<string, decimal>();
                    customer.ProductsAndQuantities.Add(product, quantity);
                    customer.Check = products[product] * quantity;

                    bool isExist = false;

                    foreach (var item in customers)
                    {
                        if (item.Name == customer.Name)
                        {
                            isExist = true;
                            if (item.ProductsAndQuantities.ContainsKey(product))
                            {
                                item.ProductsAndQuantities[product] += quantity;
                            }
                            else
                            {
                                item.ProductsAndQuantities.Add(product, quantity);
                            }

                            item.Check += products[product] * quantity;
                        }

                    }

                    if (isExist == false)
                    {
                        customers.Add(customer);
                    }
                }
            }

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                
                foreach (var productAndQuantity in customer.ProductsAndQuantities)
                {
                    Console.WriteLine($"-- {productAndQuantity.Key} - {productAndQuantity.Value}");
                }
                Console.WriteLine($"Bill: {customer.Check:F2}");
                
            }
            Console.WriteLine($"Total bill: {customers.Sum(x => x.Check):F2}");
        }
    }
}
