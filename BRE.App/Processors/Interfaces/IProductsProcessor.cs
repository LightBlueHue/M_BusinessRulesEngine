using BRE.App.Orders.Interfaces;
using BRE.App.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Processors.Interfaces
{
    /// <summary>
    /// Interface for processing products.
    /// </summary>
    public interface IProductsProcessor
    {
        /// <summary>
        /// Process products.
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        List<IProcessedOrder> Process(List<IProduct> products);
    }
}
