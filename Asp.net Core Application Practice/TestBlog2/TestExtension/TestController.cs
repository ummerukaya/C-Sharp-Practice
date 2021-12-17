using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;


namespace TestExtension
{
    public class TestController:Controller
    {
        public IActionResult Index()
        {
            return View("~/TestExtension/net5.0/Views/Index.cshtml");
        }
    }
}
