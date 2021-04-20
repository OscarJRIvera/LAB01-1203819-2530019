using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LAB01_2530019_1203819.Models;
using System.IO;
using System.Web;
using DoubleLinkedListLibrary1; 



namespace LAB01_2530019_1203819.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OptionList(int id)
        {
            if (Models.Data.Singleton.Instance.TipeList != null)
            {
                return View("index");
            }
            Models.Data.Singleton.Instance.TipeList = id == 0 ? false: true;
            return View("index");
            
        }
        //public IActionResult SubirArchivo()
        //{
           //return View();
       // }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //public IActionResult SubirArchivo(HttpPostedFileBase postedFile)
        //{
           // return View();
        //}

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
