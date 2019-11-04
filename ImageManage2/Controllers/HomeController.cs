using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ImageManage2.Manager.IContrat;
using Microsoft.AspNetCore.Mvc;
using ImageManage2.Models;

namespace ImageManage2.Controllers
{
    public class HomeController : Controller
    {
       
       
        public IActionResult Index()
        {
            return RedirectToAction("Index","Employee");
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
