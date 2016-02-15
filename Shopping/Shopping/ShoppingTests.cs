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
            var products = new Cart[] { new Cart("milk", 2), new Cart("bread", 1) };
            Assert.AreEqual(3, CalculateTheTotalPrice(products));
        }
        [TestMethod]
        public void ShouldReturnCheapestProduc()
        {
            var products = new Cart[] { new Cart("milk", 2), new Cart("bread", 1), new Cart("eggs", 4) };
            Assert.AreEqual(1, FindTheCheapestProduct(products));
        }
        [TestMethod]
        public void ShouldReturnTheAveragePrice()
        {
            var products = new Cart[] { new Cart("milk", 2), new Cart("bread", 1), new Cart("eggs", 4), new Cart("chocolate", 5) };
            Assert.AreEqual(3, CalculateTheAveragePrice(products));
        }
        [TestMethod]
        public void ShouldReturnTheMostExpensiveProduct()
        {
            var products = new Cart[] { new Cart("milk", 2), new Cart("bread", 1), new Cart("eggs", 4), new Cart("chocolate", 5) };
            Assert.AreEqual(5, FindAndRemoveTheMostExpensiveProduct(products));
        }

        public struct Cart
        {
            public string name;
            public int price;

            public Cart(string name, int price)
            {
                this.name = name;
                this.price = price;
            }
        }

        static int CalculateTheTotalPrice(Cart[] products)
        {
            int total = 0;
            for (int i = 0; i < products.Length; i++)
                total += products[i].price;
            return total;
        }

        static int FindTheCheapestProduct(Cart[] products)
        {
            int cheapestProduct = products[0].price;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].price < cheapestProduct)
                {
                    cheapestProduct = products[i].price;
                }
            }
            return cheapestProduct;
        }

        static int CalculateTheAveragePrice(Cart[] products)
        {
            int total = 0;
            for (int i = 0; i < products.Length; i++)
                total += products[i].price;
            return total / products.Length;
        }

        static int FindAndRemoveTheMostExpensiveProduct(Cart[] products)
        {
            int mostExpensive = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].price > mostExpensive)
                {
                    mostExpensive = products[i].price;
                }
            }
            return mostExpensive;
        }
    }
}
