using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPDEMO.ModelEf;
using Microsoft.EntityFrameworkCore;

namespace HTTPDEMO.Repository
{
    public class ProductRepo : BaseRepo<Product>, IProductRepo
    {

        public ProductRepo(maybanhangtudongContext context) : base(context)
        {
            _dbset = _dbContext.Set<Product>();
        }

        public decimal DayTotal()
        {
            throw new NotImplementedException();
        }

        public List<Product> FindMinAmount()
        {
            return _dbset.OrderBy(x => x.Amount).ToList();
        }

        public List<Product> GetEXP()
        {
            var productExp = _dbset.Where(x => x.Exp <= DateTime.Now).ToList();

            return productExp;
        }
    }
}
