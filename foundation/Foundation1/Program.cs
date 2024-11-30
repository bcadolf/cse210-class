using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Creating video 1
        Video video1 = new Video("Exploring the Ocean Depths", "Marine Biologist", 1200);

        video1.AddComment(new Comment("OceanLover123", "Amazing exploration!"));
        video1.AddComment(new Comment("DeepSeaDiver", "Can't wait to see more."));
        video1.AddComment(new Comment("MarineFanatic", "So fascinating! Thanks for sharing."));

        // Creating video 2
        Video video2 = new Video("The Secrets of the Universe", "Astrophysicist", 1800);

        video2.AddComment(new Comment("StarGazer", "This blew my mind!"));
        video2.AddComment(new Comment("SpaceEnthusiast", "Incredible insights."));
        video2.AddComment(new Comment("GalaxyWatcher", "Learned so much. Thank you!"));
        video2.AddComment(new Comment("CosmosExplorer", "I love space!"));

        // Creating video 3
        Video video3 = new Video("The Art of Baking Bread", "Master Baker", 900);

        video3.AddComment(new Comment("BakingLover", "Looks delicious!"));
        video3.AddComment(new Comment("BreadFanatic", "Can't wait to try this recipe."));
        video3.AddComment(new Comment("HomeCook", "Thank you for the tips!"));

        // Creating video 4
        Video video4 = new Video("A Journey Through Time", "Historian", 1500);

        video4.AddComment(new Comment("HistoryBuff", "So informative and engaging!"));
        video4.AddComment(new Comment("TimeTraveler", "Loved every minute of it."));
        video4.AddComment(new Comment("PastExplorer", "Great presentation!"));
        video4.AddComment(new Comment("ChronicleFan", "I learned so much about history."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        Console.Clear();
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");

        }
    }

}