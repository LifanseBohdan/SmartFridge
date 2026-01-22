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

        [Fact]
public void SmartFridge_ShouldReturnExpiredProduct_FromTwoGiven()
{
    var fridge = new SmartFridge();
    string name = "Молоко";

    var fresh = new Product 
    { 
        Name = name, 
        ExpiryDate = DateTime.Now.AddDays(10) 
    };

    var expired = new Product 
    { 
        Name = name, 
        ExpiryDate = DateTime.Now.AddDays(-1) 
    };

    var result = fridge.GetExpiredDuplicate(fresh, expired);

    Assert.NotNull(result);
    Assert.Equal(expired.ExpiryDate, result.ExpiryDate);
    Assert.True(result.ExpiryDate < DateTime.Now);
}
    }
}
