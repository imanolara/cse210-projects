// Program.cs
using System;
using System.Collections.Generic; // Required for List

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 Video objects
        Video video1 = new Video("How to Learn C# Fast", "CodeMaster", 600);
        Video video2 = new Video("Understanding Abstraction in OOP", "TechGuru", 900);
        Video video3 = new Video("Building Your First Console App", "DevJourney", 1200);
        Video video4 = new Video("Introduction to Data Structures", "AlgoGenius", 1500); // Fourth video

        // Add 3-4 comments to each video
        video1.AddComment(new Comment("Alice", "Great tutorial! Very helpful for beginners."));
        video1.AddComment(new Comment("Bob", "Learned a lot, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make a video on polymorphism next?"));
        video1.AddComment(new Comment("Diana", "Clear and concise explanation.")); // Fourth comment

        video2.AddComment(new Comment("Eve", "This really cleared up abstraction for me."));
        video2.AddComment(new Comment("Frank", "Excellent examples!"));
        video2.AddComment(new Comment("Grace", "Could you elaborate on abstract classes vs interfaces?"));

        video3.AddComment(new Comment("Heidi", "My first app compiled thanks to this!"));
        video3.AddComment(new Comment("Ivan", "Easy to follow steps."));
        video3.AddComment(new Comment("Judy", "Perfect for a quick start."));

        video4.AddComment(new Comment("Kevin", "Data structures made simple!"));
        video4.AddComment(new Comment("Liam", "Looking forward to more videos on algorithms."));
        video4.AddComment(new Comment("Mia", "Very foundational, thanks for sharing."));
        video4.AddComment(new Comment("Noah", "Well explained concepts.")); // Fourth comment


        // Put each of these videos in a list
        List<Video> videoList = new List<Video>();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);
        videoList.Add(video4);

        // Iterate through the list of videos and display their details
        foreach (Video video in videoList)
        {
            video.DisplayFullVideoDetails();
        }

        // Program execution finishes automatically after displaying
        // No user interaction is required as per the assignment
    }
}