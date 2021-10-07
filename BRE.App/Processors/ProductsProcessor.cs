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
    /// Processes products.
    /// </summary>
    public class ProductsProcessor : IProductsProcessor
    {
        /// <summary>
        /// Book processor.
        /// </summary>
        public IBookProductProcessor BookProcessor { get; }

        /// <summary>
        /// Physical product processor.
        /// </summary>
        public IPhysicalProductProcessor PhysicalProcessor { get; }

        /// <summary>
        /// Processes products.
        /// </summary>
        /// <param name="bookProcessor"></param>
        /// <param name="physicalProcessor"></param>
        public ProductsProcessor(IBookProductProcessor bookProcessor
            , IPhysicalProductProcessor physicalProcessor)
        {
            BookProcessor = bookProcessor ?? throw new ArgumentNullException(nameof(bookProcessor));
            PhysicalProcessor = physicalProcessor ?? throw new ArgumentNullException(nameof(physicalProcessor));
        }

        /// <summary>
        /// Process products.
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public List<IProcessedOrder> Process(List<IProduct> products)
        {
            var processedOrders = new List<IProcessedOrder>();

            if (products == null)
            {
                return processedOrders;
            }

            foreach (var item in products)
            {
                if (item is IBookProduct)
                {
                    var order = BookProcessor.Process((IBookProduct)item);
                    processedOrders.Add(order);
                }

                if (item is IPhysicalProduct)
                {
                    var order = PhysicalProcessor.Process((IPhysicalProduct)item);
                    processedOrders.Add(order);
                }
            }

            return processedOrders;
        }
    }
}
