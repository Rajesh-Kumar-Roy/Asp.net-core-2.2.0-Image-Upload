using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ImageManage2.Utilities
{
    public interface IDropDownUtities
    {
        ICollection<SelectListItem> GetAllEmployeeData();
    }
}
