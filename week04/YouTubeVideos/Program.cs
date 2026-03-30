using System;

class Program
{
    static void Main(string[] args)
    {
        //Video
        Video video1 = new Video("C# Basics Tutorial", "John Tech", 600);
        Video video2 = new Video("OOP Explained", "CodeMaster", 720);
        Video video3 = new Video("App Development Guide", "DevWorld", 900);

        // Comments video 1
        video1.AddComment(new Comment("Alex", "Very Helpful!"));
        video1.AddComment(new Comment("Maria", "Easy to follow. Thanks!"));
        video1.AddComment(new Comment("Ken", "Great explanation"));

        // Comments video 2
        video2.AddComment(new Comment("Liza", "Love it!"));
        video2.AddComment(new Comment("Tom", "Very informative."));
        video2.AddComment(new Comment("Anna", "Thanks!"));

        // Comments video 3
        video3.AddComment(new Comment("Chris", "Awesome guide!"));
        video3.AddComment(new Comment("Joy", "Learned a lot, thanks."));
        video3.AddComment(new Comment("Mark", "keep it up!"));

        // Store video in list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}