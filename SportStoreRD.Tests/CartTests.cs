using SportStoreRD.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace SportStoreRD.Tests
{
    public class CartTests
    {

        [Fact]
        public void Can_Add_New_Lines()
        {

            // Arrange - create some test products
            // Организация - создание нескольких тестовых товаров
            Product p1 = new Product { ProductId = 1, Name = "P1" };
            Product p2 = new Product { ProductId = 2, Name = "P2" };

            // Arrange - create a new cart
            // Организация - создание новой корзины
            Cart target = new Cart();

            // Act/Действие            
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            CartLine[] results = target.Lines.ToArray();

            // Assert/Утверждение
            Assert.Equal(2, results.Length);
            Assert.Equal(p1, results[0].Product);
            Assert.Equal(p2, results[1].Product);
        }

        [Fact]
        public void Can_Add_Quantity_For_Existing_Lines()
        {
            // Arrange - create some test products
            // Организация - создание нескольких тестовых товаров
            Product p1 = new Product { ProductId = 1, Name = "P1" };
            Product p2 = new Product { ProductId = 2, Name = "P2" };

            // Arrange - create a new cart
            // Организация - создание новой корзины
            Cart target = new Cart();

            // Act/Действие
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 10);
            CartLine[] results = target.Lines
                .OrderBy(c => c.Product.ProductId).ToArray();

            // Assert/Утверждение
            Assert.Equal(2, results.Length);
            Assert.Equal(11, results[0].Quantity);
            Assert.Equal(1, results[1].Quantity);
        }

        [Fact]
        public void Can_Remove_Line()
        {
            // Arrange - create some test products
            // Организация - создание нескольких тестовых товаров
            Product p1 = new Product { ProductId = 1, Name = "P1" };
            Product p2 = new Product { ProductId = 2, Name = "P2" };
            Product p3 = new Product { ProductId = 3, Name = "P3" };

            // Arrange - create a new cart
            // Организация - создание новой корзины
            Cart target = new Cart();
            // Arrange - add some products to the cart
            // Организация - добавление нескольких товаров в корзину
            target.AddItem(p1, 1);
            target.AddItem(p2, 3);
            target.AddItem(p3, 5);
            target.AddItem(p2, 1);

            // Act/Действие
            target.RemoveLine(p2);

            // Assert/Утверждение
            Assert.Equal(0, target.Lines.Where(c => c.Product == p2).Count());
            Assert.Equal(2, target.Lines.Count());
        }

        [Fact]
        public void Calculate_Cart_Total()
        {
            // Arrange - create some test products
            // Организация - создание нескольких тестовых товаров
            Product p1 = new Product { ProductId = 1, Name = "P1", Price = 100M };
            Product p2 = new Product { ProductId = 2, Name = "P2", Price = 50M };

            // Arrange - create a new cart
            // Организация - создание новой корзины
            Cart target = new Cart();

            // Act/Действие 
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 3);
            decimal result = target.ComputeTotalValue();

            // Assert/Утверждение
            Assert.Equal(450M, result);
        }

        [Fact]
        public void Can_Clear_Contents()
        {
            // Arrange - create some test products
            // Организация - создание нескольких тестовых товаров
            Product p1 = new Product { ProductId = 1, Name = "P1", Price = 100M };
            Product p2 = new Product { ProductId = 2, Name = "P2", Price = 50M };

            // Arrange - create a new cart
            // Организация - создание новой корзины
            Cart target = new Cart();

            // Arrange - add some items
            // Организация - добавление нескольких товаров
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);

            // Act - reset the cart
            // Действие - очищение корзины
            target.Clear();

            // Assert/Утверждение
            Assert.Equal(0, target.Lines.Count());
        }
    }
}