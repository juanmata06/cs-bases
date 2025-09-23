using CsBases.Fundamentals;

class Program
{
    static void Main()
    {
        // Uso de Clases e Interfaces con Herencia
        var laptop = new Product("Macbook Pro M2", 2100.99m);
        WriteLine(laptop.GetDescription());

        var soporte = new ServiceProduct("Apple Care", 101.99m, 365);
        WriteLine(soporte.GetDescription());
    }
}