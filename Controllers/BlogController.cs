using MVC_Website.Models;
using Microsoft.AspNetCore.Mvc;
using MVC_Website.Services;

namespace MVC_Website.Controllers;

public class BlogController : Controller
{
    private readonly BlogPostService _BlogpostService;

    public BlogController(BlogPostService blogPostService)
    {
        _BlogpostService = blogPostService;
    }

    public IActionResult Index()
    {
        var blogPosts = _BlogpostService.GetAllPosts();
        return View(blogPosts);
    }
}