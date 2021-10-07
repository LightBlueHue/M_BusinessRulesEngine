using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Orders.Interfaces
{
    /// <summary>
    /// Interface that represents a processed order.
    /// </summary>
    public interface IProcessedOrder
    {
        /// <summary>
        /// Product if.
        /// </summary>
        int ProductId { get; set; }

        /// <summary>
        /// Successfully processed.
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// Errors if any. 
        /// </summary>
        string Error { get; set; }
    }
}
