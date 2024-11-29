using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("Learning Git Fundamentals", "Femi Odusile", 180);
        video1.AddComment(new Comment("Taylor", "Good video"));
        video1.AddComment(new Comment("Veronica", "Nice video"));
        video1.AddComment(new Comment("Japheth", "Great explanation"));

        Video video2 = new Video("Learning C# Basics", "Femi Odusile", 300);
        video2.AddComment(new Comment("Japheth", "Good explanation"));
        video2.AddComment(new Comment("Josh", "I love the explanation"));
        video2.AddComment(new Comment("Jeff", "Great video"));

        Video video3 = new Video("C# Basics in 30 mins", "Femi Odusile", 1800);
        video3.AddComment(new Comment("Japheth", "Good explanation"));
        video3.AddComment(new Comment("Josh", "I love the explanation"));
        video3.AddComment(new Comment("Jeff", "Great video"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display details of each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }

    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthSeconds;
        private List<Comment> _comments;

        public Video(string Title, string Author, int Length)
        {
            _title = Title;
            _author = Author;
            _lengthSeconds = Length;
            _comments = new List<Comment>();
        }
        public string Title => _title;
        public string Author => _author;
        public int LengthSeconds => _lengthSeconds;
        public List<Comment> Comments => _comments;

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOfComments()
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
        public string CommenterName => _commenterName;
        public string Text => _text;
    }
}
