using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImageManage2.Manager.IContrat;
using ImageManage2.Models;
using ImageManage2.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImageManage2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeManager _employeeManager;
        private readonly IDropDownUtities _utities;
       private readonly IMapper _mapper;
       private IHostingEnvironment _hostingEnvironment;
        public EmployeeController(IEmployeeManager employeeManager, IDropDownUtities utities,IMapper mapper,IHostingEnvironment hostingEnvironment)
        {
            _mapper = mapper;
            _employeeManager = employeeManager;
            _utities = utities;
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: Employee
        [HttpGet]
        public ActionResult Index()
        {
            var employee = _employeeManager.GetAll();
            if (employee == null)
            {
                return NotFound();
            }
            var model = employee; 
            return View(model);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = _employeeManager.GetById(id);
            if (employee == null)
            {
                return NotFound();

            }

            var model = (employee);
            return View(model);
        }

        // GET: Employee/Create
        [HttpGet]
        public ActionResult Create()
        {
            var model = new EmployeeViewModel();
            model.DeptLoopupData = _utities.GetAllEmployeeData();


            return View(model);
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                   
                   
                   
                    string uniquefileName = null;
                    if (model.Photo != null)
                    {
                      string uploadsfolder =  Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                     uniquefileName= Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                     string filePath = Path.Combine(uploadsfolder, uniquefileName);
                     model.Photo.CopyTo(new FileStream(filePath,FileMode.Create));
                    }
                    //var employee = new Employee();
                    //employee.Name = model.Name;
                    //employee.DepartmentId = model.DepartmentId;

                    //employee.Email = model.Email;
                    //employee.Salary = model.Salary;
                    var employee = _mapper.Map<Employee>(model);
                    employee.PhotoPath = uniquefileName;
                   
                    var isSeccess= _employeeManager.Add(employee);
                    if (isSeccess)
                    {
                       return RedirectToAction(nameof(Index));
                    }
                }

                return NotFound();
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}