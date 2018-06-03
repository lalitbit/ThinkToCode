using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkToCode.Repository.Common
{
    public interface IBaseRepository<T> where T : new()
    { 
        long Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        IList<T> GetAll();
    }
}
