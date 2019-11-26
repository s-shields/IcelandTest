using System;
using System.Collections.Generic;
using IcelandProductTest.Console;
using NUnit.Framework;

namespace IcelandProductTest.NunitTest
{
    [TestFixture]
    public class NUnitTestForProductChecker
    {
        public List<Product> products = new List<Product>();
        public List<Product> expectedProducts = new List<Product>();

        [Test]
        public void ProductUpdater_UpdateProductList_ReturnExpectedResults()
        {
            //Arrange
            SetTestData();
            ExpectedResults();
            var productTest = new ProductChecker();

            //Act
            products = productTest.ProductUpdater(products);

            //Assert
            for (int i = 0; i < products.Count; i++)
            {
                Assert.AreEqual(products[i].Type, expectedProducts[i].Type);
                Assert.AreEqual(products[i].SellInDays, expectedProducts[i].SellInDays);
                Assert.AreEqual(products[i].Quality, expectedProducts[i].Quality);

            }
        }

        public void SetTestData()
        {
            products.Add(new Product { Type = "Aged Brie", SellInDays = 1, Quality = 1 });
            products.Add(new Product { Type = "Christmas Crackers", SellInDays = -1, Quality = 2 });
            products.Add(new Product { Type = "Christmas Crackers", SellInDays = 9, Quality = 2 });
            products.Add(new Product { Type = "Soap", SellInDays = 2, Quality = 2 });
            products.Add(new Product { Type = "Frozen Food", SellInDays = -1, Quality = 55 });
            products.Add(new Product { Type = "Frozen Food", SellInDays = 2, Quality = 2 });
            products.Add(new Product { Type = "Invalid Item", SellInDays = 2, Quality = 2 });
            products.Add(new Product { Type = "Fresh Item", SellInDays = 2, Quality = 2 });
            products.Add(new Product { Type = "Fresh Item", SellInDays = -1, Quality = 5 });
        }

        public void ExpectedResults()
        {
            expectedProducts.Add(new Product { Type = "Aged Brie", SellInDays = 0, Quality = 2 });
            expectedProducts.Add(new Product { Type = "Christmas Crackers", SellInDays = -2, Quality = 0 });
            expectedProducts.Add(new Product { Type = "Christmas Crackers", SellInDays = 8, Quality = 4 });
            expectedProducts.Add(new Product { Type = "Soap", SellInDays = 2, Quality = 2 });
            expectedProducts.Add(new Product { Type = "Frozen Food", SellInDays = -2, Quality = 50 });
            expectedProducts.Add(new Product { Type = "Frozen Food", SellInDays = 1, Quality = 1 });
            expectedProducts.Add(new Product { Type = "No Such Item", SellInDays = 0, Quality = 0 });
            expectedProducts.Add(new Product { Type = "Fresh Item", SellInDays = 1, Quality = 0 });
            expectedProducts.Add(new Product { Type = "Fresh Item", SellInDays = -2, Quality = 1 });
        }
    }
}
