public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in Products)
        {
            totalPrice += product.TotalCost;
        }

        // Shipping cost
        double shippingCost = Customer.IsInUSA() ? 5 : 35;
        totalPrice += shippingCost;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"- {product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}