using System;

class Video
{
    public string Title { get; set; }                                     //property
    public string Author { get; set; }                                    //property
    public int LengthInSeconds { get; set; }                           //property

    private List<Comment> comments;                                     //storing the comments in a list
    public Video(string title, string author, int lengthInSec)       //constructor
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSec;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)                             //adding a comment
    {
        comments.Add(comment);
    }

    public void DisplayVideoInfo()                                      //displaying the video info
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("*******************************************************");
        Console.WriteLine($"Title: {Title} \nAuthor: {Author} \nLength in Seconds: {LengthInSeconds} \nComments: ");
        foreach (var comment in comments)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            comment.DisplayComment();
        }
    }
}