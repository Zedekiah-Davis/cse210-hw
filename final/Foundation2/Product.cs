public class Product
{
    public string Name { get; set; }
    public string ProductId { get; set; }
    public double PricePerUnit { get; set; }
    public int Quantity { get; set; }

    public double TotalCost => PricePerUnit * Quantity;
}