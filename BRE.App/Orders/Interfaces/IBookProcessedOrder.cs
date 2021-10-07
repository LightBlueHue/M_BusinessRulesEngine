using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Orders.Interfaces
{
    /// <summary>
    /// IBookProcessedOrder
    /// </summary>
    public interface IBookProcessedOrder : IProcessedOrder
    {
        /// <summary>
        /// Duplicate this order.
        /// </summary>
        /// <returns></returns>
        IBookProcessedOrder Duplicate();
    }
}
