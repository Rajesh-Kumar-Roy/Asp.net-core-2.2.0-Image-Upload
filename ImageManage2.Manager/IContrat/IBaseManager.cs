using System;
using System.Collections.Generic;
using System.Text;

namespace ImageManage2.Manager.IContrat
{
    public interface IBaseManager<T>where  T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        ICollection<T> GetAll();
        T GetById(int? id);
    }
}
