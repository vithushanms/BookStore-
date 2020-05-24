using Microsoft.AspNetCore.Mvc;
using System;

namespace BookstoreApp.Controllers
{
    public class HomeController : Controller{
        public String Index(){
            return "Hey, This is vithu";
        }
    }
}