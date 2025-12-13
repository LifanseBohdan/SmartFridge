using SmartFridge;


namespace SmartFridge
{
    public class SmartFridgeService
    {
        static void Main(string[] args)
        {
            var product1 = new Product("Молоко", new DateTime(2025, 12, 31));
            var fridge = new SmartFridge();

            fridge.AddProduct(product1);
            Console.WriteLine($"Додали {product1.Name} до холодильнику");

            var product2 = new Product("Ковбаса", new DateTime(2025, 8, 31));

            fridge.AddProduct(product2);
            Console.WriteLine($"Додали {product2.Name} до холодильнику");

            var allProducts = fridge.GetAllProducts();
            Console.WriteLine("Всі продукти:");
            foreach (var p in allProducts)
            {
                Console.WriteLine($"{p.Name} - термін придатності: {p.ExpirationDate.ToShortDateString()}");
            }
            Console.WriteLine("Всі прострочені продукти:");
            var allExpiredProducts = fridge.GetExpiredProducts();

            foreach (var p in allExpiredProducts)
            {
                Console.WriteLine($"{p.Name} - термін придатності: {p.ExpirationDate.ToShortDateString()}");
            }
            fridge.RemoveProduct("Ковбаса");
            Console.WriteLine($"Прибрали {product2.Name}");
        }
    }
}