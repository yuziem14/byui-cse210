using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product("PS4DS200", "Dual Shock PS4.1", 299.99, 2));
        products.Add(new Product("POCHPS60", "Potato Chips 60g", 3.49, 3));
        products.Add(new Product("LOGKBP4", "Logtech Keyboard 4Plus", 102, 1));
        products.Add(new Product("LOGMSE24", "Logtech Mouse 2024", 61.8, 2));
        products.Add(new Product("PROJMIN300", "Mini Projector V300", 130, 1));
        products.Add(new Product("CHOCOB4R", "Chocolate Bar", 2, 10));
        products.Add(new Product("HDM1CB", "HDMI Cable 2.0", 81.5, 1));

        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer("Robin Bart", new Address("Wall Street 301", "New York", "NY", "USA")));
        customers.Add(new Customer("Marvin Alves", new Address("R. Rebouças 203", "Curitiba", "PR", "BR")));

        List<Order> orders = new List<Order>();
        orders.Add(new Order(customers[0]));
        orders[0].AddProduct(products[0]);
        orders[0].AddProduct(products[2]);
        orders[0].AddProduct(products[4]);
        orders[0].AddProduct(products[6]);

        orders.Add(new Order(customers[1]));
        orders[1].AddProduct(products[1]);
        orders[1].AddProduct(products[3]);
        orders[1].AddProduct(products[5]);

        orders.ForEach(order => {
            Console.WriteLine("Packing Label");
            Console.WriteLine(order.DisplayPackingLabel());
            Console.WriteLine();

            Console.WriteLine("Shipping Label");
            Console.WriteLine(order.DisplayShippingLabel());
            Console.WriteLine();

            Console.Write($"Total Cost: $ {order.CalculateTotalCost()}");
            Console.WriteLine();
            Console.WriteLine();
        });
    }
}