using BRE.App.Processors;
using BRE.App.Products;
using BRE.App.Products.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.UnitTest
{
    [TestFixture]
    public class ProductsProcessorTest
    {

        [TestCase]
        public void When_IntantiatedWithNullBookProcessor_Expect_ThrowsArgumentNullException()
        {
            // Arrange

            BookProductProcessor bookProcessor = null;
            var physicalProcessor = new PhysicalProductProcessor();

            // Act
            // Assert
            var exception = Assert.Throws<ArgumentNullException>(delegate
            {
                new ProductsProcessor(bookProcessor, physicalProcessor);
            });

            Assert.That(exception is ArgumentNullException);
        }

        [TestCase]
        public void When_IntantiatedWithNullPhysicalProductProcessor_Expect_ThrowsArgumentNullException()
        {
            // Arrange
            var bookProcessor = new BookProductProcessor();
            PhysicalProductProcessor physicalProcessor = null;

            // Act
            // Assert
            var exception = Assert.Throws<ArgumentNullException>(delegate
            {
                new ProductsProcessor(bookProcessor, physicalProcessor);
            });

            Assert.That(exception is ArgumentNullException);
        }

        [TestCase]
        public void When_PhysicalProductProcessorSet_Expect_CorrectPhysicalProductProcessor()
        {
            // Arrange
            var bookProcessor = new BookProductProcessor();
            var physicalProcessor = new PhysicalProductProcessor();

            // Act
            var processor = new ProductsProcessor(bookProcessor, physicalProcessor);

            // Assert

            Assert.That(physicalProcessor == processor.PhysicalProcessor);
        }

        [TestCase]
        public void When_BookProductProcessorSet_Expect_CorrectBookProductProcessor()
        {
            // Arrange
            var bookProcessor = new BookProductProcessor();
            var physicalProcessor = new PhysicalProductProcessor();

            // Act
            var processor = new ProductsProcessor(bookProcessor, physicalProcessor);

            // Assert
            Assert.That(bookProcessor == processor.BookProcessor);
        }

        [TestCase]
        public void When_ProcessCalled_Expect_DoesNotReturnNull()
        {
            // Arrange
            var bookProcessor = new BookProductProcessor();
            var physicalProcessor = new PhysicalProductProcessor();
            var processor = new ProductsProcessor(bookProcessor, physicalProcessor);

            // Act
            var result = processor.Process(new List<IProduct>());
            // Assert
            Assert.That(result != null);
        }

        [TestCase]
        public void When_ProcessCalledWithNullArgument_Expect_DoesNotReturnNull()
        {
            // Arrange
            var bookProcessor = new BookProductProcessor();
            var physicalProcessor = new PhysicalProductProcessor();
            var processor = new ProductsProcessor(bookProcessor, physicalProcessor);

            // Act
            var result = processor.Process(null);

            // Assert
            Assert.That(result != null);
        }

        [TestCase]
        public void When_ProcessCalled_Expect_ReturnsCorrectOrderCount()
        {
            // Arrange
            var bookProcessor = new BookProductProcessor();
            var physicalProcessor = new PhysicalProductProcessor();
            var processor = new ProductsProcessor(bookProcessor, physicalProcessor);

            var book = new BookProduct() { Id = 1, ISBN = "AYTG1" };
            var physicalProduct = new PhysicalProduct() { Id = 2, };

            var products = new List<IProduct> { book, physicalProduct };

            // Act
            var result = processor.Process(products);
            // Assert
            Assert.That(products.Count == result.Count);
        }

        [TestCase]
        public void When_ProcessCalled_Expect_PhysicalProcessorCalled()
        {
            // Arrange
            var mockBookProcessor = new Mock<BookProductProcessor>();
            mockBookProcessor.Setup(m => m.Process(It.IsAny<IBookProduct>()));

            var physicalProcessor = new PhysicalProductProcessor();
            var processor = new ProductsProcessor(mockBookProcessor.Object, physicalProcessor);

            var book = new BookProduct() { Id = 1, ISBN = "AYTG1" };
            var physicalProduct = new PhysicalProduct() { Id = 2, };

            var products = new List<IProduct> { book, physicalProduct };

            // Act
            var result = processor.Process(products);

            // Assert
            mockBookProcessor.VerifyAll();
        }

        [TestCase]
        public void When_ProcessCalled_Expect_BookProcessorCalled()
        {
            // Arrange
            var bookProcessor = new BookProductProcessor();

            var mockPhysicalProcessor = new Mock<PhysicalProductProcessor>();
            mockPhysicalProcessor.Setup(m => m.Process(It.IsAny<IPhysicalProduct>()));

            var processor = new ProductsProcessor(bookProcessor, mockPhysicalProcessor.Object);

            var book = new BookProduct() { Id = 1, ISBN = "AYTG1" };
            var physicalProduct = new PhysicalProduct() { Id = 2, };

            var products = new List<IProduct> { book, physicalProduct };

            // Act
            var result = processor.Process(products);

            // Assert
            mockPhysicalProcessor.VerifyAll();
        }
    }
}
