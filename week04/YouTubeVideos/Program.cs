using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold the video objects
            List<Video> videos = new List<Video>();

            // Video 1
            Video v1 = new Video("C# Abstraction Basics", "CodeWithMosh", 900);
            v1.AddComment(new Comment("User01", "This is very helpful!"));
            v1.AddComment(new Comment("DevBeginner", "Clear explanation."));
            v1.AddComment(new Comment("StudentA", "Thanks for the tutorial."));
            videos.Add(v1);

            // Video 2
            Video v2 = new Video("Lo-Fi Study Beats", "LofiGirl", 3600);
            v2.AddComment(new Comment("StudyBuddy", "Helps me focus."));
            v2.AddComment(new Comment("ZenVibes", "So peaceful."));
            v2.AddComment(new Comment("NightOwl", "Always listening at 2am."));
            videos.Add(v2);

            // Video 3
            Video v3 = new Video("How to Bake Bread", "TheBakery", 1200);
            v3.AddComment(new Comment("BakerJoe", "Mine came out perfectly!"));
            v3.AddComment(new Comment("Foodie99", "Best recipe I have found."));
            v3.AddComment(new Comment("KitchenKing", "Can I use whole wheat flour?"));
            videos.Add(v3);

            // Iterate through the list of videos and display information
            foreach (Video video in videos)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine($"Title:  {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Comments ({video.GetCommentCount()}):");
                Console.WriteLine("-----------------------------------------------");
                
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.Name}: {comment.Text}");
                }
                Console.WriteLine(); // Blank line for readability
            }
        }
    }
}