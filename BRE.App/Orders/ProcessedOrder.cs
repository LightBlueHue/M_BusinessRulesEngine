using BRE.App.Orders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Orders
{
    /// <summary>
    /// Represents a processed order.
    /// </summary>
    public class ProcessedOrder : IProcessedOrder
    {
        /// <summary>
        /// Product if.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Successfully processed.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Errors if any. 
        /// </summary>
        public string Error { get; set; }
    }
}
