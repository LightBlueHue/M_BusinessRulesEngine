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
    public class MembershipUpgradeProductTest
    {
        [TestCase]
        public void When_IdSet_Expect_CorrectId()
        {
            // Arrange
            var id = 1;
            var product = new MembershipUpgradeProduct();

            // Act
            product.Id = id;

            // Assert
            Assert.That(product.Id == id);
        }

        [TestCase]
        public void When_Instantiated_Expect_IMembershipUpgradeProduct()
        {
            // Arrange
            var id = 1;
            var product = new MembershipUpgradeProduct();

            // Act
            product.Id = id;

            // Assert
            Assert.That(product is IMembershipUpgradeProduct);
        }

        [TestCase]
        public void When_Instantiated_Expect_IProduct()
        {
            // Arrange
            var id = 1;
            var product = new MembershipUpgradeProduct();

            // Act
            product.Id = id;

            // Assert
            Assert.That(product is IProduct);
        }
    }
}
