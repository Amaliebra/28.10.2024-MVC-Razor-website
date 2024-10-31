using MVC_Website.Models;
using Microsoft.AspNetCore.Mvc;
using MVC_Website.Services;

namespace MVC_Website.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            InspirationWords = new InspirationWords()
            //Do i want more items??????????
        };
        return View(model);
    }

    public IActionResult Home()
    {
        return View();
    }
    
    public IActionResult Blog()
    {
        return View();
    }
}
