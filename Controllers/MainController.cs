using MVC_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.AspNetCore.Controllers;

public class MainController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}