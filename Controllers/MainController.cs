using MVC_Website.Models;
using Microsoft.AspNetCore.Mvc;
using MVC_Website.Services;

namespace Microsoft.AspNetCore.Controllers;

public class MainController : Controller
{
    private readonly BlogPostService _BlogpostService;

    public MainController(BlogPostService blogPostService)
    {
        _BlogpostService = blogPostService;
    }

    public IActionResult Index()
    {
        var blogPosts = _BlogpostService.GetAllPosts();
        return View(blogPosts);
    }

}
