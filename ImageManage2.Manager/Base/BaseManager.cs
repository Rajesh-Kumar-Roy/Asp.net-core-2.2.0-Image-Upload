using System;
using System.Collections.Generic;
using System.Text;
using ImageManage2.Manager.IContrat;
using ImageManger2.Repository.IContract;

namespace ImageManage2.Manager.Base
{
    public class BaseManager<T>:IBaseManager<T>where T:class
    {
        private IBaseRepository<T> _baseRepository;
        public BaseManager(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public bool Add(T entity)
        {
            return _baseRepository.Add(entity);
        }

        public bool Update(T entity)
        {
            return _baseRepository.Update(entity);
        }

        public bool Remove(T entity)
        {
            return _baseRepository.Remove(entity);
        }

        public ICollection<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public T GetById(int? id)
        {
            return _baseRepository.Get(id);
        }
    }
}
