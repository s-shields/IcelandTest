﻿using System;
using IcelandProductTest.Console;
using NUnit.Framework;

namespace IcelandProductTest.NunitTest
{
    [TestFixture]
    public class NUnitTestForDecreasedQuality
    {
        [Test]
        public void DecreasedQuality_DecreasingProductQuailty_QualityReturns10()
        {
            //Arrange
            int productQuality = 15;
            int qualityIncreaseAmount = 5;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void DecreasedQuality_DecreasingProductQuailtyLessThan0_QualityReturns0()
        {
            //Arrange
            int productQuality = -5;
            int qualityIncreaseAmount = 6;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void DecreasedQuality_DecreasingProductQuailtyMoreThan0_QualityReturns0()
        {
            //Arrange
            int productQuality = 2;
            int qualityIncreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void DecreasedQuality_DecreasingProductQuailtyTo0_QualityReturns0()
        {
            //Arrange
            int productQuality = 0;
            int qualityIncreaseAmount = 0;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void DecreasedQuality_DecreasingProductQuailtyLessThan50_QualityReturns49()
        {
            //Arrange
            int productQuality = 50;
            int qualityIncreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(49, result);
        }

        [Test]
        public void DecreasedQuality_DecreasingProductQuailtyMoreThan50_QualityReturns50()
        {
            //Arrange
            int productQuality = 52;
            int qualityIncreaseAmount = 1;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void DecreasedQuality_DecreasingProductQuailtyTo50_QualityReturns50()
        {
            //Arrange
            int productQuality = 50;
            int qualityIncreaseAmount = 0;

            ProductChecker productChecker = new ProductChecker();
            //Act
            var result = productChecker.DecreaseQuality(productQuality, qualityIncreaseAmount);

            //Assert
            Assert.AreEqual(50, result);
        }
    }
}