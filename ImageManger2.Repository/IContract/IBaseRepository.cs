using System;
using System.Collections.Generic;
using System.Text;

namespace ImageManger2.Repository.IContract
{
    public interface IBaseRepository<T> where T:class
    {
        ICollection<T> GetAll();
        T Get(int? id);
        bool Add(T entity);
        bool Remove(T entity);
        bool Update(T entity);
    }
}
