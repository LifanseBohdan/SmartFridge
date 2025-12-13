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

        public bool RemoveProduct(string productName)
        {
            var prod = _products.FirstOrDefault(x => x.Name == productName);
            if (prod == null) return false;
            _products.Remove(prod);
            return true;
        }
    }
}
