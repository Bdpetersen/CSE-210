using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address 1 (USA)
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M200", 25.50, 2));

        // Create Address 2 (International)
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "D300", 200.00, 2));
        order2.AddProduct(new Product("HDMI Cable", "C400", 15.00, 3));
        order2.AddProduct(new Product("Keyboard", "K500", 50.00, 1));

        // Display Results
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Price: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }
    }
}