using MVC_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.AspNetCore.Controllers;

public class MainController : Controller
{
    private readonly List<BlogPost> _blogPosts = new();
    public IActionResult Index()
    {
        if (!_blogPosts.Any())
        {
            _blogPosts.Add(new BlogPost { Title = "Heia bloggen!", Content = "Dette er mitt første blogginnlegg! Håper dere gleder dere til neste oppdatering." });
        }

        return View(_blogPosts);
    }


}
