using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImageManger2.Repository.IContract;
using Microsoft.EntityFrameworkCore;

namespace ImageManger2.Repository.Base
{
    public class BaseRepository<T>:IBaseRepository<T> where T: class
    {
        private readonly DbContext db;

        public BaseRepository(DbContext db)
        {
            this.db = db;
        }

        public DbSet<T> Table
        {
            get { return db.Set<T>(); }
        }

        public ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public T Get(int? id)
        {
            return Table.Find(id);
        }

        public bool Add(T entity)
        {
            Table.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Remove(T entity)
        {
            Table.Remove(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
