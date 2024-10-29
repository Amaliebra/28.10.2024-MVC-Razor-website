using MVC_Website.Models;
using Microsoft.AspNetCore.Mvc;
using MVC_Website.Services;

namespace MVC_Website.Controllers;

public class MainController : Controller
{
    public IActionResult Index()
    {
        var InspirationWords = new InspirationWords();
        return View(InspirationWords);
    }

}
