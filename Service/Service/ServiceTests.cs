using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var products = new Product[] { new Product("Siemens", "Low"), new Product("Nokia", "Medium"), new Product("Alcatel", "High") };
            var expected = new Product[] { new Product("Alcatel", "High"), new Product("Nokia", "Medium"), new Product("Siemens", "Low") };
            CollectionAssert.AreEqual(expected, Sort(products));
        }

        public struct Product
        {
            public string name;
            public string priority;

            public Product(string name, string priority)
            {
                this.name = name;
                this.priority = priority;
            }
        }

        static Product[] Sort(Product[] products)
        {
            return products;
        }
    }
}
