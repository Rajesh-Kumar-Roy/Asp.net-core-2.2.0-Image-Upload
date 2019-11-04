using System;
using System.Collections.Generic;
using System.Text;
using ImageManage2.Manager.Base;
using ImageManage2.Manager.IContrat;
using ImageManage2.Models;
using ImageManger2.Repository.IContract;

namespace ImageManage2.Manager
{
    public class EmployeeManager:BaseManager<Employee>,IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository employeeRepository):base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        
    }
}
