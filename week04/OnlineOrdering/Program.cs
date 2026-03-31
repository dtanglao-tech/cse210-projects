using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P002", 20, 2));

        Address address2 = new Address("456 Rizal St", "Manila", "Metro Manila", "Philippines");
        Customer customer2 = new Customer("Juan DelaCruz", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P003", 50, 1));
        order2.AddProduct(new Product("Headphones", "P004", 100, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\n----------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");

    }
}