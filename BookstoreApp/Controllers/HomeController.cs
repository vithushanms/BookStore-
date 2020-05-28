using Microsoft.AspNetCore.Mvc;
using System;

namespace BookstoreApp.Controllers
{
    public class HomeController : Controller{
        public ViewResult Index(){
            return View();
        }

        public ViewResult aboutus(){
            return View();
        }

        public ViewResult contactus(){
            return View();
        }
    }
}