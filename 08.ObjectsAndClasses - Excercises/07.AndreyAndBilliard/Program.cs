using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> priceList = new Dictionary<string, double>();
            var n = int.Parse(Console.ReadLine());
            List<Customer> allOrders = new List<Customer>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').ToArray();
                var product = input[0];
                double price = double.Parse(input[1]);
                priceList[product] = price;
            }

            var order = Console.ReadLine();

            while (order != "end of clients")
            {
                var orderByItem = order.Split(new char[] { '-', ',' });
                var clientName = orderByItem[0];
                var productName = orderByItem[1];
                var quantity = int.Parse(orderByItem[2]);

                if (priceList.ContainsKey(productName))
                {
                    var currentClient = new Customer();
                    currentClient.Name = clientName;
                    currentClient.Product = new Dictionary<string, int>();
                    currentClient.Product[productName] = quantity;
                    currentClient.Bill = priceList[productName] * quantity;
                    allOrders.Add(currentClient);
                }
                order = Console.ReadLine();
            }

            double totalSum = 0.0;

            foreach (var output in allOrders.OrderBy(x => x.Name))
            {
                Console.WriteLine(output.Name);
                foreach (var product in output.Product)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {output.Bill:f2}");
                totalSum += output.Bill;
            }

            Console.WriteLine($"Total bill: {totalSum:f2}");

        }

        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> Product { get; set; }
            public double Bill { get; set; }
        }
    }
}
