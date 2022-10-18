using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPDEMO.ModelEf;

namespace HTTPDEMO.Repository
{
    public class CategoryProductRepo : BaseRepo<CategoryProduct>, ICategoryProductRepo
    {
        public CategoryProductRepo(maybanhangtudongContext context) : base(context)
        {
        }

        public string ListCategory()
        {
            return "aa";
        }
    }
}
