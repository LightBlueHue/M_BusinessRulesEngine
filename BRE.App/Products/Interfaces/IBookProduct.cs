using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Products.Interfaces
{
    /// <summary>
    /// Interface for a book product
    /// </summary>
    public interface IBookProduct: IProduct
    {
        /// <summary>
        /// ISBN.
        /// </summary>
        public string ISBN { get; set; }
    }
}
