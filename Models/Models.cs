namespace MVC_Website.Models;

public class BlogPost
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
}

public class MainIndex 
{
    public string? Headline { get; set;}
}

public class InspirationWords
{
    public List<string> Words {get; set;}

    public InspirationWords()
    {
        Words = new List<string>
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
}
