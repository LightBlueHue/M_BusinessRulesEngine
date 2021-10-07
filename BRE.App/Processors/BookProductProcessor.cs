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
    /// Processes a book product.
    /// </summary>
    public class BookProductProcessor : IBookProductProcessor
    {
        /// <summary>
        /// Process
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public virtual IProcessedOrder Process(IBookProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            var order = new BookProcessedOrder();
            order.ProductId = product.Id;

            var duplicate = order.Duplicate();
            //Todo: Send duplicate packing slip to the royalty department.
            // This can be by calling an object passed through the constructor.
            // Mqtt / message broker also possible
            // The duplicate can hold an id of the original.
            // I'm past 2 hours now

            return order;
        }
    }
}
