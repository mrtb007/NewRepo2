using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPDEMO.ModelEf;

namespace HTTPDEMO.Repository
{
    public interface ICategoryProductRepo : IBaseRepo<CategoryProduct>
    {
        public string ListCategory();
    }    
}
