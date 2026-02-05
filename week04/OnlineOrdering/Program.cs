using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Maple St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L402", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "M10", 25.50, 2));

        // Order 2: International Customer
        Address address2 = new Address("456 Rue de Rivoli", "Paris", "IDF", "France");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "K80", 120.00, 1));
        order2.AddProduct(new Product("Webcam", "W50", 75.00, 1));
        order2.AddProduct(new Product("USB Cable", "U01", 12.99, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine("---------------------------\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");
    }
}