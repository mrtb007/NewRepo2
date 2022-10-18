using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPDEMO.ModelEf;
using Microsoft.EntityFrameworkCore;

namespace HTTPDEMO.Repository
{
    public class BaseRepo<T> :IBaseRepo<T> where T : class
    {
        protected readonly maybanhangtudongContext _dbContext;
        protected DbSet<T> _dbset;

        public BaseRepo(maybanhangtudongContext context)
        {
            _dbContext = context;
            _dbset = _dbContext.Set<T>();
        }

        public bool Create(T model)
        {
            var results = _dbset.Add(model);
            Save();
            return true;
        }

        public bool Delete(string id)
        {
            var item = _dbset.Find(id);
            _dbset.Remove(item);
            Save();
            return true;
        }

        public T Find(string id)
        {
            return _dbset.Find(id);
        }

        public List<T> GetAll()
        {
            //dbset => AEnumerable, AQueryable
           return _dbset.ToList();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public bool Update(T model)
        {
            var results = _dbset.Update(model);
            Save();
            return true;
        }
    }
}
