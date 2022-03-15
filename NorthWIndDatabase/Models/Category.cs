using NorthWindDatabase.BaseModel;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWIndDatabase.Models
{
    public partial class Category:NorthWindBaseModel
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
