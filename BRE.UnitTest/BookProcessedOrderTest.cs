using BRE.App.Orders.Interfaces;
using BRE.App.Processors;
using BRE.App.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.UnitTest
{
    [TestFixture]
    public class BookProcessedOrderTest
    {
        [TestCase]
        public void When_ProcessCalled_Expect_OrderIsIProcessedOrder()
        {
            // Arrange
            var productId = 1;
            var product = new BookProduct();
            product.Id = productId;

            var processor = new BookProductProcessor();

            // Act
            var order = processor.Process(product);

            // Assert
            Assert.That(order is IProcessedOrder);
        }

        [TestCase]
        public void When_ProcessCalled_Expect_OrderIsIBookProcessedOrder()
        {
            // Arrange
            var productId = 1;
            var product = new BookProduct();
            product.Id = productId;

            var processor = new BookProductProcessor();

            // Act
            var order = processor.Process(product);

            // Assert
            Assert.That(order is IBookProcessedOrder);
        }


        [TestCase]
        public void When_DuplicateCalled_Expect_DuplicateOrderNotNull()
        {
            // Arrange
            var productId = 1;
            var product = new BookProduct();
            product.Id = productId;

            var processor = new BookProductProcessor();
            IBookProcessedOrder order = (IBookProcessedOrder)processor.Process(product);

            // Act
            var duplicateOrder = order.Duplicate();

            // Assert
            Assert.That(duplicateOrder != null);
        }

        [TestCase]
        public void When_DuplicateCalled_Expect_DuplicateOrderDifferentToOriginalOrder()
        {
            // Arrange
            var productId = 1;
            var product = new BookProduct();
            product.Id = productId;

            var processor = new BookProductProcessor();
            IBookProcessedOrder order = (IBookProcessedOrder)processor.Process(product);

            // Act
            var duplicateOrder = order.Duplicate();

            // Assert
            Assert.That(order != duplicateOrder);
        }

        [TestCase]
        public void When_DuplicateCalled_Expect_SameValues()
        {
            // Arrange
            var productId = 1;
            var product = new BookProduct();
            product.Id = productId;

            var processor = new BookProductProcessor();
            IBookProcessedOrder order = (IBookProcessedOrder)processor.Process(product);

            // Act
            var duplicateOrder = order.Duplicate();

            // Assert
            Assert.That(order.Error == duplicateOrder.Error);
            Assert.That(order.ProductId == duplicateOrder.ProductId);
            Assert.That(order.Success == duplicateOrder.Success);
        }
    }
}
