using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImageManage2.Models;

namespace ImageManage2.ConfigureAutoMapper
{
    public class EmployeeAutomapper:Profile
    {
        public EmployeeAutomapper()
        {
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeViewModel,Employee>();
           
        }
    }
}
