using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPDEMO.ModelEf;

namespace HTTPDEMO.Repository
{
    public interface IProductRepo : IBaseRepo<Product> 
    {
        public decimal DayTotal();
        public List<Product> GetEXP();
        public List<Product> FindMinAmount();
    }
}
