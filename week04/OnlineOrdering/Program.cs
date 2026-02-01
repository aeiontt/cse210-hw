using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learning C#", "CodeMaster", 600);
        Video video2 = new Video("OOP Explained", "TechTalks", 480);
        Video video3 = new Video("Abstraction Basics", "DevSimplified", 720);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("Bob", "Clear explanation."));
        video1.AddComment(new Comment("Chris", "Thanks for this video."));

        // Add comments to video 2
        video2.AddComment(new Comment("Dami", "OOP finally makes sense."));
        video2.AddComment(new Comment("Sarah", "Nice examples."));
        video2.AddComment(new Comment("Mike", "Well explained."));

        // Add comments to video 3
        video3.AddComment(new Comment("John", "Great breakdown."));
        video3.AddComment(new Comment("Emma", "Simple and clear."));
        video3.AddComment(new Comment("Leo", "Loved this lesson."));

        // Store videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        // Display video details
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }
        }
    }
}