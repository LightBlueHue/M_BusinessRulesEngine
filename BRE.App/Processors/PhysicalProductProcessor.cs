using BRE.App.Orders;
using BRE.App.Orders.Interfaces;
using BRE.App.Processors.Interfaces;
using BRE.App.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Processors
{
    /// <summary>
    /// Processes a physical product
    /// </summary>
    public class PhysicalProductProcessor : IPhysicalProductProcessor
    {
        /// <summary>
        /// Process
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public virtual IProcessedOrder Process(IPhysicalProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            var order = new ProcessedOrder();
            order.ProductId = product.Id;
            return order;
        }
    }
}
