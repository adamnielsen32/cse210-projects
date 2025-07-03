using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Address address1 = new Address("123 Apple St", "Boise", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Headphones", "HD123", 49.99, 2));
        order1.AddProduct(new Product("Charger", "CH567", 19.99, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("------------------------------------------------");

        Address address2 = new Address("56 Queen St", "London", "LDN", "UK");
        Customer customer2 = new Customer("Alice Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "NB321", 6.99, 3));
        order2.AddProduct(new Product("Pens", "PN654", 1.99, 10));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}