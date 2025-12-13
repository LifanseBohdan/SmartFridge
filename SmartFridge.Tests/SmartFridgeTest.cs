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
    }
}