using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<VIdeo> videos = new List<VIdeo>();

        VIdeo vIdeo1 = new VIdeo("Learning Git Fundamentals", "Femi Odusile", 180);
        vIdeo1.AddComment(new Comment("Taylor", "Good Video"));
        vIdeo1.AddComment(new Comment("Veronica", "Nice Video"));
        vIdeo1.AddComment(new Comment("Iyanu", "Good explanation"));
        vIdeo1.AddComment(new Comment("Japheth", "Great explanation"));

        VIdeo vIdeo2 = new VIdeo("Learning C# Basics", "Femi Odusile", 300);
        vIdeo2.AddComment(new Comment("Iyanu", "Good explanation"));
        vIdeo2.AddComment(new Comment("Veronica", "Awesome Video"));
        vIdeo2.AddComment(new Comment("Japheth", "Nice video"));

        VIdeo vIdeo3 = new VIdeo("Learn C# Basics in 30 mins", "Femi Odusile", 1800);
        vIdeo3.AddComment(new Comment("Josh", "Good video"));
        vIdeo3.AddComment(new Comment("Veronica", "Nice Video"));
        vIdeo3.AddComment(new Comment("Japheth", "Nice explanation"));
        vIdeo3.AddComment(new Comment("Iyanu", "Good explanation"));

        videos.Add(vIdeo1);
        videos.Add(vIdeo2);
        videos.Add(vIdeo3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberofComments()}");
            Console.WriteLine("Comments: ");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" . {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}

public class VIdeo
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public VIdeo(string Title, string Author, int Length)
    {
        _title = Title;
        _author = Author;
        _lengthSeconds = Length;
        _comments = new List<Comment>();
    }
    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string Title)
    {
        _title = Title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string Author)
    {
        _author = Author;
    }
    public int GetLengthSeconds()
    {
        return _lengthSeconds;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberofComments()
    {
        return _comments.Count;
    }
}
public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string CommenterName, string Text)
    {
        _commenterName = CommenterName;
        _text = Text;
    }
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetText()
    {
        return _text;
    }
}