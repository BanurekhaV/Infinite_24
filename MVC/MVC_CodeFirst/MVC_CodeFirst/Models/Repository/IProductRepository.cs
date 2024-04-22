using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Repository
{
    public interface IProductRepository<T> where T:class  //allows only reference types
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);  //a particular product
        void Insert(T obj);
        void Update(T obj);
        void Delete(Object Id);
        void Save();
    }
}
