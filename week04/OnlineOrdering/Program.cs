using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Creating an order for the customer
        Order order1 = new Order(customer1);

        // Adding products to the order
        order1.AddProduct(new Product("Laptop", "P001", 1000.00, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.00, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 50.00, 1));

        // Displaying order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n=================================\n");

        // Creating another customer outside the USA
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating a second order
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "P004", 800.0, 1));
        order2.AddProduct(new Product("Headphones", "P005", 100.0, 1));

        // Displaying second order details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}