using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.Comments.Add(new Comment("User1", "Great video!"));
        video1.Comments.Add(new Comment("User2", "Awesome content!"));
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.Comments.Add(new Comment("User3", "Nice explanation!"));
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.Comments.Add(new Comment("User4", "Insightful video!"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}