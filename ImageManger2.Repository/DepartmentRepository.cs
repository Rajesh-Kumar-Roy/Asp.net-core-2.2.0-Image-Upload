using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImageManage2.DbContext;
using ImageManage2.Models;
using ImageManger2.Repository.Base;
using ImageManger2.Repository.IContract;
using Microsoft.EntityFrameworkCore;

namespace ImageManger2.Repository
{
    public class DepartmentRepository:BaseRepository<Department>,IDepartmentRepository
    {
        private readonly DbContext db;

        protected ImageDbContext Context
        {
            get { return (ImageDbContext) db; }
        }
        public DepartmentRepository(DbContext db) : base(db)
        {
            this.db = (ImageDbContext) db;
        }
        public ICollection<Department> GetDept()
        {
            return Context.Departments.ToList();
        }
    }
}
