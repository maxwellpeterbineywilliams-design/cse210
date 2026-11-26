using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");


        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Programming","John Smith",600);

        video1.AddComment(new Comment("Peter", "this is eye opening!"));
        video1.AddComment(new Comment("Biney", "very insightful thank you."));
        video1.AddComment(new Comment("Ruth", "simple and easy to understand."));


        Video video2 = new Video( "Understanding the Scriptures","Peter Biney",480);

        video2.AddComment(new Comment("Kwame", "i had no idea."));
        video2.AddComment(new Comment("Kofi", "wow i have learned so much."));
        video2.AddComment(new Comment("Akosua", "Thank you for this."));


        Video video3 = new Video( "Growth in the Spirit","George Ahenkofi",720);

        video3.AddComment(new Comment("Peter", "the Holy SPIRIT is our only hope."));
        video3.AddComment(new Comment("Susan", "what a blessing"));
        video3.AddComment(new Comment("Robert", "i am inspired and very motivated."));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }

}