namespace SmartFridge.Tests
{
    public class SmartFridgeTest
    {
        [Fact]
        public void AddProduct_WhenCalled_ShouldAddProductToList()
        {
            var fridge = new SmartFridge();
            var product = new Product("Milk", DateTime.Now.AddDays(5));

            fridge.AddProduct(product);

            var products = fridge.GetAllProducts();
            Assert.Contains(product, products);
        }

        [Fact]
        public void RemoveProduct_WhenProductExists_ShouldRemoveSuccessfully()
        {
            var fridge = new SmartFridge();
            var product = new Product("Cheese", DateTime.Now.AddDays(3));
            fridge.AddProduct(product);

            var result = fridge.RemoveProduct("Cheese");

            Assert.True(result);
            Assert.DoesNotContain(product, fridge.GetAllProducts());
        }

        [Fact]
        public void RemoveProduct_WhenProductDoesNotExist_ShouldReturnFalse()
        {
            var fridge = new SmartFridge();

            var result = fridge.RemoveProduct("OrangeJuice");

            Assert.False(result);
        }

        [Fact]
        public void GetExpiredProducts_WhenSomeProductsExpired_ShouldReturnOnlyExpired()
        {
            var fridge = new SmartFridge();
            var fresh = new Product("Bread", DateTime.UtcNow.AddDays(2));
            var expired = new Product("Yogurt", DateTime.UtcNow.AddDays(-1));
            fridge.AddProduct(fresh);
            fridge.AddProduct(expired);

            var expiredProducts = fridge.GetExpiredProducts();

            Assert.Single(expiredProducts);
            Assert.Equal("Yogurt", expiredProducts[0].Name);
        }
    }
}