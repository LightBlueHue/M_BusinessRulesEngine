using BRE.App.Orders;
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
    public class ProcessedOrderTest
    {
        [TestCase]
        public void When_ProductIdSet_Expect_CorrectProductId()
        {
            // Arrange
            var productId = 1;
            var order = new ProcessedOrder();

            // Act
            order.ProductId = productId;

            // Assert
            Assert.That(order.ProductId == productId);
        }

        [TestCase]
        public void When_SuccesSetTrue_Expect_SuccessTrue()
        {
            // Arrange
            var success = true;
            var order = new ProcessedOrder();

            // Act
            order.Success = success;

            // Assert
            Assert.That(order.Success == success);
        }

        [TestCase]
        public void When_SuccesSetFalse_Expect_SuccessFalse()
        {
            // Arrange
            var success = false;
            var order = new ProcessedOrder();

            // Act
            order.Success = success;

            // Assert
            Assert.That(order.Success == success);
        }

        [TestCase]
        public void When_ErrorSet_Expect_SameError()
        {
            // Arrange
            var error = "This is an error";
            var order = new ProcessedOrder();

            // Act
            order.Error = error;

            // Assert
            Assert.That(order.Error == error);
        }
    }
}
