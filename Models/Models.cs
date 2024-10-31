namespace MVC_Website.Models;

public class BlogPost
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
}

public class InspirationWords
{
    public List<string> Words {get;} = new List<string>
        {
            "Believe",
            "Dream",
            "Hope",
            "Inspire",
            "Grow",
            "Learn",
            "Succeed",
            "Achieve",
            "Overcome",
            "Peace",
            "Courage",
            "Persevere",
            "Determination",
            "Enthusiasm",
            "Innovation",
            "Passion",
            "Creativity"
        };
}

public class HomeViewModel
{
    public InspirationWords? InspirationWords { get; set; }
}