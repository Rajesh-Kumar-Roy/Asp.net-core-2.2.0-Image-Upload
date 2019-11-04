using System;
using System.Collections.Generic;
using System.Text;
using ImageManage2.Models;

namespace ImageManger2.Repository.IContract
{
    public interface IDepartmentRepository:IBaseRepository<Department>
    {
        ICollection<Department> GetDept();
    }
}
