using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Products.Interfaces
{
    /// <summary>
    /// Interface for a product
    /// </summary>
   public interface IProduct
    {
        /// <summary>
        /// Product id.
        /// </summary>
        public int Id { get; set; }
    }
}
