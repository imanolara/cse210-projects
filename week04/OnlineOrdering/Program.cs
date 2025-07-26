// Program.cs
using System;
using System.Collections.Generic; // Required for List

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1: USA Customer ---
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "PROD001", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "ACC005", 25.00, 2)); // 2 mice for $50 total
        order1.AddProduct(new Product("Keyboard", "ACC010", 75.00, 1));


        Console.WriteLine("--- Order 1 Details ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 1 Total Cost: ${order1.GetTotalCost():F2}"); // :F2 for 2 decimal places
        Console.WriteLine("\n-----------------------------------\n");


        // --- Order 2: International Customer ---
        Address address2 = new Address("45 Wallaby Way", "Sydney", "NSW", "Australia");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "ELEC002", 300.00, 1));
        order2.AddProduct(new Product("Webcam", "ACC015", 50.00, 1));


        Console.WriteLine("--- Order 2 Details ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 2 Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine("\n-----------------------------------\n");

        // No user interaction is required as per the assignment
    }
}