using ShoppingApplication.model;

class Program
{
    public static void Main(string[] args)
    {

        Customer customer1 = new Customer(1, "Sanskruti");

        Product product1 = new Product(1, "Bread", 75, 5);
        Product product2 = new Product(2, "Cheese", 185, 8);
        Product product3 = new Product(3, "Jam", 200, 10);
        Product product4 = new Product(4, "Butter", 150, 5);

        LineItem lineitem1 = new LineItem(1, 2, product1);
        LineItem lineitem2 = new LineItem(2, 2, product2);
        LineItem lineItem3 = new LineItem(3, 1, product3);
        LineItem lineItem4 = new LineItem(4, 3, product4);


        Order order1 = new Order(1, DateTime.Now);
        order1.Items.Add(lineitem1);
        order1.Items.Add(lineitem2);

        customer1.CustomerOrder.Add(order1);


        Order order2 = new Order(2, DateTime.Now);
        order2.Items.Add(lineItem3);
        order2.Items.Add(lineItem4);

        customer1.CustomerOrder.Add(order2);

        Customer.PrintOrderDetails(customer1);

    }
}