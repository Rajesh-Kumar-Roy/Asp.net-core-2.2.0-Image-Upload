using System;
using System.Collections.Generic;
using System.Text;
using ImageManage2.Manager.Base;
using ImageManage2.Manager.IContrat;
using ImageManage2.Models;
using ImageManger2.Repository.IContract;

namespace ImageManage2.Manager
{
    public class DepartmentManager:BaseManager<Department>,IDepartmentManager
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentManager(IDepartmentRepository departmentRepository):base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public ICollection<Department> GetDept()
        {
            return _departmentRepository.GetDept();
        }
    }
}
