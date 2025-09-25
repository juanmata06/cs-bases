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

        // Aplicación de patron ADAPTER mediante un DTO
        var mouse = new Product("Magic mouse", 85.99m);
        var productDto = ProductAdapter.ToDto(mouse);
        WriteLine($"{productDto.Name} - {productDto.Price:C} - Código: {productDto.Code}");

        // Inyección de dependencias
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var monitor = new Product("Apple Pro Display", 5000.99m);
        var installation = new ServiceProduct("Instalación de monitor", 20.99m, 1);
        manager.PrintLabel(monitor);
        manager.PrintLabel(installation);
    }
}