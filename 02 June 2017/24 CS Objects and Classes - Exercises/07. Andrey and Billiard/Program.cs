using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> BoughtProducts { get; set; }
            public double Bill { get; set; }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var shopStock = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');

                var product = input[0];
                var price = double.Parse(input[1]);

                if (!shopStock.ContainsKey(product))
                    shopStock.Add(product, price);
                else
                    shopStock[product] = price;
            }

            var customerList = new List<Customer>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of clients") break;

                var clientInput = input.Split('-', ',');
                var name = clientInput[0];
                var product = clientInput[1];
                var quantity = int.Parse(clientInput[2]);

                if (shopStock.ContainsKey(product))
                {

                    var client = new Customer();
                    client.Name = name;
                    client.BoughtProducts = new Dictionary<string, int>();
                    client.BoughtProducts.Add(product, quantity);

                    if (customerList.Any(a => a.Name == name))
                    {
                        Customer existingCustomer = customerList.First(a => a.Name == name);
                        if (existingCustomer.BoughtProducts.ContainsKey(product))
                        {
                            existingCustomer.BoughtProducts[product] += quantity;
                        }
                        else
                        {
                            existingCustomer.BoughtProducts[product] = quantity;
                        }
                    }
                    else
                    {
                        customerList.Add(client);
                    }
                }
            }

            foreach (var customer in customerList)
            {
                foreach (var item in customer.BoughtProducts)
                {
                    foreach (var product in shopStock)
                    {
                        if (item.Key == product.Key)
                            customer.Bill += item.Value * product.Value;
                    }
                }
            }

            var output = customerList
                .OrderBy(a => a.Name)
                .ToList();

            foreach (Customer customers in output)
            {
                Console.WriteLine(customers.Name);
                foreach (KeyValuePair<string, int> item in customers.BoughtProducts)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customers.Bill:F2}");
            }
            var totalBill = customerList.Sum(a => a.Bill);
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}