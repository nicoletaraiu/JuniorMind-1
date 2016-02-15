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
        static int CalculateTheTotalPrice(Cart[] goods)
        {
            int total = 0;
            for (int i = 0; i < goods.Length; i++)
                total += goods[i].price;
            return total;
        }
    }
}
