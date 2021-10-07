using BRE.App.Orders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Orders
{
    /// <summary>
    /// Book process order.
    /// </summary>
    public class BookProcessedOrder : ProcessedOrder, IBookProcessedOrder
    {
        /// <summary>
        /// Duplicate this order.
        /// </summary>
        /// <returns></returns>
        public IBookProcessedOrder Duplicate()
        {
            return new BookProcessedOrder
            {
                Error = this.Error,
                ProductId = this.ProductId,
                Success = this.Success
            };
        }
    }
}
