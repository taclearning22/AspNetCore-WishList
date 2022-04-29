using System;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string viewName)
        {
            return View("Index");
        }
        public IActionResult Error(string viewName)
        {
            return View("Error");
        }
    }
}
