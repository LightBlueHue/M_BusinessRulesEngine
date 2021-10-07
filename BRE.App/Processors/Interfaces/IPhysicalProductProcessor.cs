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
    /// Interface for a processor that processes physical products.
    /// </summary>
    public interface IPhysicalProductProcessor
    {
        /// <summary>
        /// Process
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        IProcessedOrder Process(IPhysicalProduct product);
    }
}
