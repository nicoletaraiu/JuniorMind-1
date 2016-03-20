using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void ShouldReturnSortedArray()
        {
            var products = new Product[] { new Product("Siemens", Priority.Low), new Product("Nokia", Priority.Medium), new Product("Alcatel", Priority.High) };
            var expected = new Product[] { new Product("Alcatel", Priority.High), new Product("Nokia", Priority.Medium), new Product("Siemens", Priority.Low) };
            CollectionAssert.AreEqual(expected, Sort(products));
        }
        [TestMethod]
        public void ShouldReturnSortedArraY()
        {
            var products = new Product[]
            {
                new Product("Nokia", Priority.Medium),
                new Product("Sagem", Priority.High),
                new Product("Siemens", Priority.Low),
                new Product("Samsung", Priority.Medium),
                new Product("Huawei", Priority.Low),
                new Product("Alcatel", Priority.High)
            };
            var expected = new Product[]
            {
                new Product("Sagem", Priority.High),
                new Product("Alcatel", Priority.High),
                new Product("Nokia", Priority.Medium),
                new Product("Samsung", Priority.Medium),
                new Product("Siemens", Priority.Low),
                new Product("Huawei", Priority.Low)
            };
            CollectionAssert.AreEqual(expected, Sort(products));
        }
        
        public enum Priority
        {
            Low = 3,
            Medium = 2,
            High = 1
        }

        public struct Product
        {
            public string name;
            public Priority priority;

            public Product(string name, Priority priority)
            {
                this.name = name;
                this.priority = priority;
            }
        }

        static Product[] Sort(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                for (int j = 0; j < products.Length - 1; j++)
                {
                    if (products[j].priority > products[j + 1].priority)
                        Swap(ref products[j], ref products[j + 1]);
                }
            }
            return products;
        }

        static void Swap(ref Product a, ref Product b)
        {
            Product temp = a;
            a = b;
            b = temp;
        }
    }
}
