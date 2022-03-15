using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWIndDatabase.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
