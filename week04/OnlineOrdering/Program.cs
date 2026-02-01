using System;

class Program
{
    static void Main(string[] args)
    {
        // -------- ORDER 1 (USA CUSTOMER) --------
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));

        // Display order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine();

        // -------- ORDER 2 (INTERNATIONAL CUSTOMER) --------
        Address address2 = new Address(
            "45 Adeola Odeku Street",
            "Lagos",
            "Lagos",
            "Nigeria"
        );

        Customer customer2 = new Customer("Damilare Bamisile", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P2001", 500, 1));
        order2.AddProduct(new Product("Earbuds", "P2002", 50, 2));
        order2.AddProduct(new Product("Charger", "P2003", 20, 1));

        // Display order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}