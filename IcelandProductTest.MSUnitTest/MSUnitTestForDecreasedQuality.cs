using System;
using IcelandProductTest.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IcelandProductTest.MSUnitTest
{
    [TestClass]
    public class MSUnitTestForDecreasedQuality
    {
        [TestMethod]
        public void DecreasedQuality_DecreasingProductQuailty_QualityReturns10()
        {
            //Arrange
            int productQuality = 15;
            int qualityDecreaseAmount = 5;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityDecreaseAmount);

            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void DecreasedQuality_DecreasingProductQuailtyLessThan0_QualityReturns0()
        {
            //Arrange
            int productQuality = 0;
            int qualityDecreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityDecreaseAmount);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void DecreasedQuality_DecreasingProductQuailtyMoreThan0_QualityReturns0()
        {
            //Arrange
            int productQuality = 2;
            int qualityDecreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityDecreaseAmount);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DecreasedQuality_DecreasingProductQuailtyTo0_QualityReturns0()
        {
            //Arrange
            int productQuality = 0;
            int qualityDecreaseAmount = 0;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityDecreaseAmount);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void IncreasedQuality_IncreasingProductQuailtyLessThan50_QualityReturns49()
        {
            //Arrange
            int productQuality = 50;
            int qualityDecreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityDecreaseAmount);

            //Assert
            Assert.AreEqual(49, result);
        }

        [TestMethod]
        public void IncreasedQuality_IncreasingProductQuailtyMoreThan50_QualityReturns50()
        {
            //Arrange
            int productQuality = 50;
            int qualityDecreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityDecreaseAmount);

            //Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void IncreasedQuality_IncreasingProductQuailtyTo50_QualityReturns50()
        {
            //Arrange
            int productQuality = 50;
            int qualityDecreaseAmount = 0;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityDecreaseAmount);

            //Assert
            Assert.AreEqual(50, result);
        }
    }
}
