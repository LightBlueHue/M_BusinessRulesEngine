using BRE.App.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Products
{
    /// <summary>
    /// Represents a physical product.
    /// </summary>
    public class PhysicalProduct : IPhysicalProduct
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }
    }
}
