namespace CsBases.Fundamentals;

public class Product : iProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal? Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UniqueCode { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        CreatedAt = DateTime.Now;
        UniqueCode = Guid.NewGuid();
    }

    public void ApplyDiscount(decimal percentage)
    {
        var discountAmount = Price * (Price / 100);
        Price -= discountAmount;
    }

    public virtual string GetDescription()
    {
        return $"{Name} - {Price:C}";
    }
}

class ServiceProduct : Product
{
    public int DurationInDays { get; set; }

    public ServiceProduct(string name, decimal price, int duration) : base(name, price)
    {
        DurationInDays = duration;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} - Duración: {DurationInDays} días";
    }
}