using MVC_Website.Models;

namespace MVC_Website.Services
{
    public class BlogPostService
    {
        private readonly List<BlogPost> _blogPosts = new();
        public IEnumerable<BlogPost> GetAllPosts()
        {
            if (!_blogPosts.Any())
            {
                _blogPosts.Add(new BlogPost { Title = "Heia bloggen!", Content = "Dette er mitt første blogginnlegg! Håper dere gleder dere til neste oppdatering." });
            }

            return _blogPosts;
        }
    }
}