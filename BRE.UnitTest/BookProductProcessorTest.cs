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
    public class BookProductProcessorTest
    {
        [TestCase]
        public void When_ProcessCalled_Expect_ProductIdCorrect()
        {
            // Arrange
            var productId = 1;
            var product = new BookProduct();
            product.Id = productId;

            var processor = new BookProductProcessor();

            // Act
            var order = processor.Process(product);

            // Assert
            Assert.That(order.ProductId == productId);
        }

        [TestCase]
        public void When_WhenPassedNull_Expect_ThrowsArgumentNullException()
        {
            // Arrange
            BookProduct product = null;

            var processor = new BookProductProcessor();

            // Assert
            // Assert
            Assert.Throws<ArgumentNullException>(delegate { processor.Process(product); });
        }
    }
}
