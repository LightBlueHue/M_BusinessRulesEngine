using BRE.App.Products;
using BRE.App.Products.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.UnitTest
{
    [TestFixture]
    public class BookProductTest
    {
        [TestCase]
        public void When_IdSet_Expect_CorrectId()
        {
            // Arrange
            var bookId = 1;
            var book = new BookProduct();

            // Act
            book.Id = bookId;

            // Assert
            Assert.That(book.Id == bookId);
        }

        [TestCase]
        public void When_IsbnSet_Expect_CorrectId()
        {
            // Arrange
            var bookId = 1;
            var isbn = "AYTG1";
            var book = new BookProduct();

            // Act
            book.Id = bookId;
            book.ISBN = isbn;

            // Assert
            Assert.That(book.ISBN == isbn);
        }

        [TestCase]
        public void When_Instantiated_Expect_IBookProduct()
        {
            // Arrange
            var bookId = 1;
            var isbn = "AYTG1";
            var book = new BookProduct();

            // Act
            book.Id = bookId;
            book.ISBN = isbn;

            // Assert
            Assert.That(book is IBookProduct);
        }

        [TestCase]
        public void When_Instantiated_Expect_IProduct()
        {
            // Arrange
            var bookId = 1;
            var isbn = "AYTG1";
            var book = new BookProduct();

            // Act
            book.Id = bookId;
            book.ISBN = isbn;

            // Assert
            Assert.That(book is IProduct);
        }
    }
}
