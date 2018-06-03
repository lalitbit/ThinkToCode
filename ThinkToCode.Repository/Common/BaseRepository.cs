using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkToCode.Repository.Common
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : new()
    {
        public virtual IList<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public virtual long Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
