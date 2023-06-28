using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("BUY vs DIY - Viral 'Cat Ball'", "Evan and Katelyn", 1642);
    
        Comment c1V1 = new Comment("James","now I want to do that! My cat is going to love it");
        Comment c2V1 = new Comment("Taylor","Bruh, too complicated for me, buying is better");
        Comment c3V1 = new Comment("Amelia","<3 Cat!!! <3");

        v1.comments.Add(c1V1);
        v1.comments.Add(c2V1);
        v1.comments.Add(c3V1);
        videos.Add(v1);

        
        Video v2 = new Video("How to embarrass a Thief", "Daily Dose Of Internet", 221);
                
        Comment c1V2 = new Comment("Douglas","The end was surprising.");
        Comment c2V2 = new Comment("Sora","Taking notes for the future...");
        Comment c3V2 = new Comment("Viviana","That is so funny!!");

        v2.comments.Add(c1V2);
        v2.comments.Add(c2V2);
        v2.comments.Add(c3V2);
        videos.Add(v2);


        Video v3 = new Video("I Tried Butler Academy", "Michelle Khare", 1984);

        Comment c1V3 = new Comment("Leon","That is a lot harder than I thought it would be");
        Comment c2V3 = new Comment("Mark","I bet i would be a really cool Butler");
        Comment c3V3 = new Comment("Aly","Could never");

        v3.comments.Add(c1V3);
        v3.comments.Add(c2V3);
        v3.comments.Add(c3V3);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine($"\nVideo: '{v._title}'  by {v._author}  ({v._length} seconds)");
            Console.WriteLine($"Number of comments: {v.numberOfComments()}");
        }
    }
}