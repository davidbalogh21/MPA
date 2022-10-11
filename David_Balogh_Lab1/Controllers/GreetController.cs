using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace David_Balogh_Lab1.Controllers
{
    public class GreetController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public string CustomGreet(string name, int age = 21)
        {
            return "Hello " + name + ", you are " + age + " years old! Welcome to my web application!";
        }
    }
}