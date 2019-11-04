using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ImageManage2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public Collection<Employee> Employee { get; set; }
    }
}
