using System;


class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video of puppies", "Dude", 26);
        Video video2 = new Video("Video about sewing", "Dudette", 38);
        Video video3 = new Video("Video of PawPatrol reviews", "Bro", 326);
        Video video4 = new Video("Video of blacksmithing", "Chica", 808);

        video1.AddComment(new Comment("So silly", "Eva"));
        video1.AddComment(new Comment("No control of limbs", "Morgan"));
        video1.AddComment(new Comment("It was adorable", "August"));
        video1.AddComment(new Comment("All the puppies were cute.", "Adam"));
        video2.AddComment(new Comment("I should try that!", "Daniel"));
        video2.AddComment(new Comment("She must not have very many kids", "Liz"));
        video2.AddComment(new Comment("Tag <Melissa>", "Isaac"));
        video2.AddComment(new Comment("I'm going to make that!", "Melissa"));
        video3.AddComment(new Comment("Eh, not my favorite", "Charlotte"));
        video3.AddComment(new Comment("This is a baby show", "Bram"));
        video3.AddComment(new Comment("It's so weird that they talk", "Renn"));
        video3.AddComment(new Comment("My puppy", "Yelena"));
        video4.AddComment(new Comment("My dad can do it better", "Ezra"));
        video4.AddComment(new Comment("You're doing it wrong", "John"));
        video4.AddComment(new Comment("Dang!", "Joe"));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        foreach (Video video in videos)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            video.DisplayVideoInfo();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}