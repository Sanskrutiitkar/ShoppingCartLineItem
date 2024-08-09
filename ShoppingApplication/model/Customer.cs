using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.model
{
    internal class Customer : Order
    {
        private int _id;
        private string _name;
        private List<Order> _customerOrders = new List<Order>();


        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } } 
        public List<Order> CustomerOrder { get { return _customerOrders; } set { _customerOrders = value; } }
        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
           
        }

        public static void PrintOrderDetails(Customer customer)
        {
            Console.WriteLine($"{"Customer:",-20} {customer.Name}");
            Console.WriteLine($"{"ID:",-20} {customer.Id}");
            Console.WriteLine($"{"Order Count:",-20} {customer.CustomerOrder.Count}");
            Console.WriteLine();

            foreach (Order order in customer.CustomerOrder)
            {
                Console.WriteLine($"\n{"Order ID:",-20} {order.Id}");
                Console.WriteLine($"{"Date:",-20} {order.Date.ToString("yyyy-MM-dd")}");
                Console.WriteLine(new string('-', 100));
                Console.WriteLine($"{"Line Item ID",-15} {"Product",-20} {"Quantity",-10} {"Original Price",-15} {"Discounted Price",-15} {"Total Cost",-15}");
                Console.WriteLine(new string('-', 100));

                foreach (LineItem lineItem in order.Items)
                {
                    Product product = lineItem.Product;
                    double originalPrice = product.Price;
                    double discountedPrice = Product.CalculateDiscountedPrice(product);
                    double lineItemCost = LineItem.CalculateLineItemCost(lineItem);

                    Console.WriteLine($"{lineItem.Id,-15} {product.Name,-20} {lineItem.Quantity,-10} {originalPrice,-15} {discountedPrice,-15} {lineItemCost,-15}");
                }

                double totalOrderPrice = CalculateOrderPrice(order);
                Console.WriteLine(new string('-', 100));
                Console.WriteLine($"{"Total Order Price:",-50} {totalOrderPrice,34}");
                Console.WriteLine(new string('-', 100));
            }
        }

    }

}
