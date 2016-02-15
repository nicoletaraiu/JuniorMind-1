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
            var prices = new Cart[] { new Cart("milk", 2), new Cart("bread", 1) };
            Assert.AreEqual(3, CalculateTheTotalPrice(prices));
        }
        [TestMethod]
        public void ShouldReturnCheapestProduc()
        {
            var products = new Cart[] { new Cart("milk", 2), new Cart("bread", 1), new Cart("eggs", 4) };
            Assert.AreEqual(1, FindTheCheapestProduct(products));
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
    }
}
