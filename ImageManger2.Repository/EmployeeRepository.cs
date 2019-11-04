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
    public  class EmployeeRepository:BaseRepository<Employee>,IEmployeeRepository
    {
        private readonly DbContext db;

        private ImageDbContext context
        {
            get { return (ImageDbContext) db; }
        }
        public EmployeeRepository(DbContext db) : base(db)
        {
            this.db = (ImageDbContext) db;
        }

       
    }
}
