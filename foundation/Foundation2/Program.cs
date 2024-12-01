using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA", 10001);
        Customer customer1 = new Customer("John", "Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 999.99));
        order1.AddProduct(new Product("Mouse", 102, 19.99));
        order1.AddProduct(new Product("Keyboard", 103, 49.99));

        Address address2 = new Address("456 Elm St", "San Francisco", "CA", "USA", 94107);
        Customer customer2 = new Customer("Jane", "Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", 104, 199.99));
        order2.AddProduct(new Product("USB Cable", 105, 9.99, 6));

        Address address3 = new Address("789 Oak St", "Toronto", "ON", "Canada", 12345);
        Customer customer3 = new Customer("Alice", "Johnson", address3);
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Printer", 106, 149.99));
        order3.AddProduct(new Product("Ink Cartridge", 107, 29.99, 4));
        order3.AddProduct(new Product("Paper", 108, 5.99, 9));

        Console.Clear();

        Console.WriteLine(order1.GetPackingLabel());
        FormatUSAShipping(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        FormatUSAShipping(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order3.GetPackingLabel());
        FormatCanadaShipping(order3.GetShippingLabel());

    }


    static void FormatUSAShipping(string address)
    {
        string[] divided = address.Split(",");
        Console.WriteLine($"{divided[0]}\n{divided[1]}\n{divided[2]}, {divided[3]} {divided[4]}\n{divided[5]}");
    }
    static void FormatCanadaShipping(string address)
    {
        string[] divided = address.Split(",");
        Console.WriteLine($"{divided[0]}\n{divided[1]}\n{divided[2]}, {divided[3]} {divided[4]}\n{divided[5]}");
    }
}