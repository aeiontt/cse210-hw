namespace YouTubeVideos
{
    public class Comment
    {
        // Properties must be public so they can be accessed in Program.cs
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }
}