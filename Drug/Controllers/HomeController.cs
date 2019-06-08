using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Drug.Models;

namespace Drug.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GroupList countryList = new GroupList();
            return View(countryList);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("/{guid}")]
        public IActionResult Details(string guid)
        {
            GroupList group = new GroupList();
            var selected = group.DrugGroups.FirstOrDefault(d => d.AwonOgun.Exists(f => f.ID == guid)).AwonOgun.FirstOrDefault(g => g.ID == guid);
            return View(selected);
        }

        [Route("/Order")]
        public IActionResult Order()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
