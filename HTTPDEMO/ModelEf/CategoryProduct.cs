using System;
using System.Collections.Generic;

#nullable disable

namespace HTTPDEMO.ModelEf
{
    public partial class CategoryProduct
    {
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string ProductId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
