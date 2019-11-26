using System;
using IcelandProductTest.Console;
using NUnit.Framework;

namespace IcelandProductTest.NunitTest
{
    [TestFixture]
    public class NUnitTestForIncreasedQuality
    {
        [Test]
        public void IncreasedQuality_IncreasingProductQuailty_QualityReturns7()
        {
            //Arrange
            int productQuality = 5;
            int qualityIncreaseAmount = 2;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.IncreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(7, result);
        }

        [Test]
        public void IncreasedQuality_IncreasingProductQuailtyLessThan50_QualityReturns49()
        {
            //Arrange
            int productQuality = 48;
            int qualityIncreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.IncreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(49, result);
        }

        [Test]
        public void IncreasedQuality_IncreasingProductQuailtyMoreThan50_QualityReturns50()
        {
            //Arrange
            int productQuality = 51;
            int qualityIncreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.IncreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void IncreasedQuality_IncreasingProductQuailtyTo50_QualityReturns50()
        {
            //Arrange
            int productQuality = 50;
            int qualityIncreaseAmount = 0;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.IncreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(50, result);
        }
    }
}
