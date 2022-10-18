using System;
using System.Collections.Generic;

#nullable disable

namespace HTTPDEMO.ModelEf
{
    public partial class Category
    {
        public Category()
        {
            CategoryProducts = new HashSet<CategoryProduct>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string CodeCategory { get; set; }

        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
