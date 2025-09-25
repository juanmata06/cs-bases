using CsBases.Fundamentals;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        WriteLine("Buscando información ....");
        await Task.Delay(2000);
        return new Product("Producto simulado", 90);
    }
}