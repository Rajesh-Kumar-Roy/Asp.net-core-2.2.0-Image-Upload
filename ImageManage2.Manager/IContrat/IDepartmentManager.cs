using System;
using System.Collections.Generic;
using System.Text;
using ImageManage2.Models;

namespace ImageManage2.Manager.IContrat
{
    public interface IDepartmentManager:IBaseManager<Department>
    {
        ICollection<Department> GetDept();
    }
}
