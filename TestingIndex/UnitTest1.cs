using IndexIceTask;

namespace TestingIndex
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProductId()
        {
            Products product = new Products(1, "Laptop", "Electronics", 999.99, 10);
            Assert.AreEqual(1, product[0]);
        }

        [TestMethod]
        public void TestUpdateProductName()
        {
            Products product = new Products(1, "Laptop", "Electronics", 999.99, 10);
            product[1] = "Gaming Laptop";
            Assert.AreEqual("Gaming Laptop", product[1]);
        }

        [TestMethod]
        public void TestCategoryByName()
        {
            Products product = new Products(1, "Laptop", "Electronics", 999.99, 10);
            Assert.AreEqual("Electronics", product["category"]);
        }

        [TestMethod]
        public void TestUpdatePriceByName()
        {
            Products product = new Products(1, "Laptop", "Electronics", 999.99, 10);
            product["price"] = 1099.99;
            Assert.AreEqual(1099.99, product["price"]);
        }

        [TestMethod]
        public void TestStock()
        {
            Products product = new Products(1, "Laptop", "Electronics", 999.99, 10);
            Assert.AreEqual(10, product[4]);
        }
    }
}