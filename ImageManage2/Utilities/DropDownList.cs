using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageManage2.Manager.IContrat;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ImageManage2.Utilities
{
    public class DropDownList:IDropDownUtities
    {
        private IEmployeeManager _employeeManager;
        private IDepartmentManager _departmentManager;

        public DropDownList(IEmployeeManager employeeManager,IDepartmentManager departmentManager)
        {
            _employeeManager = employeeManager;
            _departmentManager = departmentManager;
        }
        public ICollection<SelectListItem> GetAllEmployeeData()
        {
            return _departmentManager.GetDept().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
        }
    }
}
