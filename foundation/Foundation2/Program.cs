using System;
using System.ComponentModel.DataAnnotations.Schema;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("111 Maple Street", "Cozy Town", "VT", "USA");
        Customer customer1 = new Customer("BillyJoe Hatfield", address1);

        Address address2 = new Address("222 Lost Street", "Nowhere", "NM", "USA");
        Customer customer2 = new Customer("BobiJoe McCoy", address2);

        Product product1 = new Product("50 Gallon Barrel", 63284, 49.99, 20);
        Product product2 = new Product("Spade shovel", 62844, 24.59, 4);
        Product product3 = new Product("40lbs Swine Feed", 99258, 26.74, 2);


        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        Console.WriteLine("***************************************************************");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalOrderCost());
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine();

        Console.WriteLine("***************************************************************");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalOrderCost());
        Console.ForegroundColor = ConsoleColor.Gray;

    }
}