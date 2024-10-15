using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; set; }                  //property 
    public string Text { get; set; }                  //property

    public Comment(string name, string text)        //constructor
    {
        Name = name;
        Text = text;
    }

    public void DisplayComment()                    //display method
    {
        Console.WriteLine($"{Name}: {Text}");
    }

}