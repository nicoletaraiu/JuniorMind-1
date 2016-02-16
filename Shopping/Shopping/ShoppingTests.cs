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
        public void ShouldRemoveTheMostExpensiveProduct()
        {
            var products = new Product[] { new Product("milk", 2), new Product("bread", 1), new Product("eggs", 4), new Product("chocolate", 5), new Product("water", 3), new Product("flowers", 2) };
            CollectionAssert.AreEqual(new Product[] { new Product("milk", 2), new Product("bread", 1), new Product("eggs", 4), new Product("water", 3), new Product("flowers", 2) }, FindAndRemoveTheMostExpensiveProduct(products));
        }
        [TestMethod]
        public void ShouldRemoveMostExpensiveProduct()
        {
            var products = new Product[] { new Product("milk", 2), new Product("oil", 10), new Product("bread", 1), new Product("eggs", 4), new Product ("pencil", 8), new Product("chocolate", 5), new Product("water", 3), new Product("oranges", 9), new Product("flowers", 2) };
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

        static Product[] FindAndRemoveTheMostExpensiveProduct(Product[] products)
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
            for (int i = reminder; i < products.Length - 1; i++)
            {
                products[i] = products[i + 1];
            }
            Array.Resize(ref products, products.Length - 1);
            return products;
        }
    }
}


