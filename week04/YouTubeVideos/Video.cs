// Video.cs
using System;
using System.Collections.Generic; // Required for List

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments; // A list to store Comment objects

    // Constructor to initialize video details and the comments list
    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>(); // Initialize the list
    }

    // Method to add a new comment to the video's list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to return the number of comments for this video
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display all details of the video, including its comments
    public void DisplayFullVideoDetails()
    {
        Console.WriteLine($"--- Video Details ---");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        if (_comments.Count == 0)
        {
            Console.WriteLine("    No comments yet.");
        }
        else
        {
            // Iterate through the comments and call their display method
            foreach (Comment comment in _comments)
            {
                comment.DisplayComment();
            }
        }
        Console.WriteLine(); // Add an empty line for better readability between videos
    }
}