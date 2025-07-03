using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Mountain Biking", "RideorDie", 300, new List<Comment>());
        video1.AddComment(new Comment("Jake", "Awesome video!"));
        video1.AddComment(new Comment("Emily", "I want to try this!"));
        video1.AddComment(new Comment("Sam", "Love the views."));
        videos.Add(video1);

        Video video2 = new Video("Sourdough Basics", "Maddiebakes", 450, new List<Comment>());
        video2.AddComment(new Comment("Lisa", "I tried it and it worked!"));
        video2.AddComment(new Comment("Tom", "Thanks for the tips."));
        video2.AddComment(new Comment("Mary", "Great explanation."));
        videos.Add(video2);

        Video video3 = new Video("Military Fitness Test", "FitOps", 600, new List<Comment>());
        video3.AddComment(new Comment("James", "wow, these guys are fit!"));
        video3.AddComment(new Comment("Rachel", "This was super helpful."));
        video3.AddComment(new Comment("Nate", "What’s a passing score?"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"{video.DisplayVideo()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetAuthor()}: {comment.GetText()}");
            }
        }
    }
}