using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, List<double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "stocked") break;

                var name = input[0];
                var price = double.Parse(input[1]);
                var quantity = int.Parse(input[2]);

                if (!database.ContainsKey(name))
                {
                    database.Add(name, new List<double>());
                    database[name].Add(price);
                    database[name].Add(0);
                }
                else if (!database[name].Contains(price))
                {
                    var oldStock = database[name][1];

                    database.Remove(name);
                    database.Add(name, new List<double>());
                    database[name].Add(price);
                    database[name].Add(oldStock);
                }

                database[name][1] += quantity;
            }

            double totalPrice = 0;

            foreach (var item in database)
            {
                var name = item.Key;
                var price = item.Value[0];
                var stock = item.Value[1];
                var itemPrice = price * stock;
                totalPrice += itemPrice;

                Console.WriteLine($"{name}: ${price:F2} * {stock} = ${itemPrice:F2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalPrice:F2}");
        }
    }
}
