namespace SmartFridge
{
    public class SmartFridge
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
            _products.Add(p);

        }
        public List<Product> GetAllProducts()
        {
            return new List<Product>(_products);
        }
    }
}
