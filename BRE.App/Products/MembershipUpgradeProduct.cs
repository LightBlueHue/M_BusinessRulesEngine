using BRE.App.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Products
{
    /// <summary>
    /// Represents a membership upgrade product.
    /// </summary>
    public class MembershipUpgradeProduct : IMembershipUpgradeProduct
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }
    }
}
