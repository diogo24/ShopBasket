using NUnit.Framework;
using Shop;
using Shop.Interfaces;
using Shop.Models;
using System.Collections.Generic;

namespace MSMGTest
{
    public class ShopTests
    {
        public IEnumerable<IOffer> Offers { get; set; }

        [SetUp]
        public void Setup()
        {
            var offers = new List<IOffer>() {
                new OfferBread(),
                new OfferMilk()
            };


            Offers = offers;
        }

        [Test]
        public void Scenario1_BreadButterMilk_Total295()
        {
            // Arrange
            var basket = new Basket(Offers);

            // Act
            basket.AddProduct(1, new Bread(1.00m));
            basket.AddProduct(1, new Butter(0.80m));
            basket.AddProduct(1, new Milk(1.15m));

            // Assert
            Assert.AreEqual(2.95, basket.TotalAmount());
        }

        [Test]
        public void Scenario2_2Bread2Butter_Total310()
        {
            // Arrange
            var basket = new Basket(Offers);

            // Act
            basket.AddProduct(2, new Bread(1.00m));
            basket.AddProduct(2, new Butter(0.80m));

            // Assert
            Assert.AreEqual(3.10, basket.TotalAmount());
        }

        [Test]
        public void Scenario3_4Milk_Total345()
        {
            // Arrange
            var basket = new Basket(Offers);

            // Act
            basket.AddProduct(4, new Milk(1.15m));

            // Assert
            Assert.AreEqual(3.45, basket.TotalAmount());
        }

        [Test]
        public void Scenario4_Bread2Butter8Milk_Total900()
        {
            // Arrange
            var basket = new Basket(Offers);

            // Act
            basket.AddProduct(1, new Bread(1.00m));
            basket.AddProduct(2, new Butter(0.80m));
            basket.AddProduct(8, new Milk(1.15m));

            // Assert
            Assert.AreEqual(9.00, basket.TotalAmount());
        }
    }
}
