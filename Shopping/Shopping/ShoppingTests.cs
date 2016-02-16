using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shopping
{
    [TestClass]
    public class ShoppingTests
    {
        [TestMethod]
        public void ShouldCalculateTheTotalPrice()
        {
            var products = new Product[] { new Product("milk", 2), new Product("bread", 1) };
            Assert.AreEqual(3, CalculateTheTotalPrice(products));
        }
        [TestMethod]
        public void ShouldReturnCheapestProduc()
        {
            var products = new Product[] { new Product("milk", 2), new Product("bread", 1), new Product("eggs", 4) };
            Assert.AreEqual(1, FindTheCheapestProduct(products));
        }
        [TestMethod]
        public void ShouldReturnTheAveragePrice()
        {
            var products = new Product[] { new Product("milk", 2), new Product("bread", 1), new Product("eggs", 4), new Product("chocolate", 5) };
            Assert.AreEqual(3, CalculateTheAveragePrice(products));
        }
        [TestMethod]
        public void ShouldReturnTheMostExpensiveProduct()
        {
            var products = new Product[] { new Product("milk", 2), new Product("bread", 1), new Product("eggs", 4), new Product("chocolate", 5) };
            Assert.AreEqual(new Product("chocolate", 5), FindAndRemoveTheMostExpensiveProduct(products));
        }

        public struct Product
        {
            public string name;
            public int price;

            public Product(string name, int price)
            {
                this.name = name;
                this.price = price;
            }
        }

        static decimal CalculateTheTotalPrice(Product[] products)
        {
            decimal total = 0;
            for (int i = 0; i < products.Length; i++)
                total += products[i].price;
            return total;
        }

        static decimal FindTheCheapestProduct(Product[] products)
        {
            decimal cheapestProduct = products[0].price;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].price < cheapestProduct)
                {
                    cheapestProduct = products[i].price;
                }
            }
            return cheapestProduct;
        }

        static decimal CalculateTheAveragePrice(Product[] products)
        {
            decimal total = 0;
            for (int i = 0; i < products.Length; i++)
                total += products[i].price;
            return total / products.Length;
        }

        static Product FindAndRemoveTheMostExpensiveProduct(Product[] products)
        {
            decimal mostExpensive = 0;
            int reminder = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].price > mostExpensive)
                {
                    mostExpensive = products[i].price;
                    reminder = i;
                }
            }
            return products[reminder];
        }
    }
}
