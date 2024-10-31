using MVC_Website.Models;
using Microsoft.AspNetCore.Mvc;
using MVC_Website.Services;

namespace MVC_Website.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var InspirationWords = new InspirationWords();
        return View(InspirationWords);
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
