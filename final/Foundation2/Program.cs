using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address
        {
            StreetAddress = "123 Main St",
            City = "Cityville",
            State = "CA",
            Country = "USA"
        };

        Customer customer1 = new Customer
        {
            Name = "John Doe",
            Address = address1
        };

        Product product1 = new Product
        {
            Name = "Product 1",
            ProductId = "P1",
            PricePerUnit = 10,
            Quantity = 2
        };

        Product product2 = new Product
        {
            Name = "Product 2",
            ProductId = "P2",
            PricePerUnit = 20,
            Quantity = 1
        };

        Order order1 = new Order(customer1);
        order1.Products.Add(product1);
        order1.Products.Add(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");
    }
}