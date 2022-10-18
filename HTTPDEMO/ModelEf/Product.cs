using System;
using System.Collections.Generic;

#nullable disable

namespace HTTPDEMO.ModelEf
{
    public partial class Product
    {
        public Product()
        {
            CategoryProducts = new HashSet<CategoryProduct>();
        }

        public string Id { get; set; }
        public string CodeProduct { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public DateTime Exp { get; set; }
        public DateTime Mfg { get; set; }

        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
