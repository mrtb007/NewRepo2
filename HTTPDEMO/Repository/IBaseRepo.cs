using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HTTPDEMO.Repository
{
    public interface IBaseRepo<T> where T : class
    {
        public List<T> GetAll();
        public bool Delete(string id);
        public void Save();
        public bool Update(T model);
        public bool Create(T model);

        public T Find(string id);
    }
}