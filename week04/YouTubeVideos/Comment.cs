// Comment.cs
using System;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    // Constructor to initialize a comment
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Method to display the comment's details
    public void DisplayComment()
    {
        Console.WriteLine($"    Comment by {_commenterName}: \"{_commentText}\"");
    }
}