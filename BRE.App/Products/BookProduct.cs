using BRE.App.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.App.Products
{
    /// <summary>
    /// Represents a book
    /// </summary>
    public class BookProduct : IBookProduct
    {
        /// <summary>
        /// Book Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ISBN.
        /// </summary>
        public string ISBN { get; set; }
    }
}
