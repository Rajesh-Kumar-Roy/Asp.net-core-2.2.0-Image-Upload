using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ImageManage2.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IFormFile Photo { get; set; }
        public decimal Salary { get; set; }
       
        public int DepartmentId { get; set; }
        [Display(Name = "Department")]
        public Department Department { get; set; }
        public ICollection<SelectListItem> DeptLoopupData { get; set; }
    }
}
