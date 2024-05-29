using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Video Final Project!\n");

        List<Video> videoList = new List<Video>();

        //video 1
        Video vid1 = new Video();
        vid1._title = "Dance like ya wanna";
        vid1._length = "202";
        vid1._author = "Lindy Corpar";

        //comment 1 video 1
        Comment vid1Com1 = new Comment();
        vid1Com1._name = "Jeffrey Carr";
        vid1Com1._comText = "I love your dance moves in this video!";
        
        //comment 2 video 1
        Comment vid1Com2 = new Comment();
        vid1Com2._name = "Gina Beggin";
        vid1Com2._comText = "Your music is so great!";
        
        //comment 2 video 1
        Comment vid1Com3 = new Comment();
        vid1Com3._name = "Carly Dang";
        vid1Com3._comText = "Finally! I am hooked on this awesome video!";

        //video 2
        Video vid2 = new Video();
        vid2._title = "Flower Blossom";
        vid2._length = "178";
        vid2._author = "Jessica White";

        //comment 1 video 2
        Comment vid2Com1 = new Comment();
        vid2Com1._name = "Janice Ike";
        vid2Com1._comText = "This is just beautiful. I absolutely love it!";
        
        //comment 2 video 2
        Comment vid2Com2 = new Comment();
        vid2Com2._name = "Carl Mc Gregor";
        vid2Com2._comText = "Very talented! Keep up the great work!";
        
        //comment 3 video 2
        Comment vid2Com3 = new Comment();
        vid2Com3._name = "Jenny Shipley";
        vid2Com3._comText = "I have this song on repeat in my household because it is so uplifting and beautiful!";

        //video 3
        Video vid3 = new Video();
        vid3._title = "You are amazing to me";
        vid3._length = "252";
        vid3._author = "Craig Mc Donald";

        //comment 1 video 3
        Comment vid3Com1 = new Comment();
        vid3Com1._name = "Dan Efferson";
        vid3Com1._comText = "My wife loves this song! We sing along to it on our travels together as it reminds us of the love we share.";
        
        //comment 2 video 3
        Comment vid3Com2 = new Comment();
        vid3Com2._name = "Dean Carlough";
        vid3Com2._comText = "Great music! I have been practising this number on my guitar and close to refining the tune.";
        
        //comment 3 video 3
        Comment vid3Com3 = new Comment();
        vid3Com3._name = "Beth Conolly";
        vid3Com3._comText = "This song reminds me of my late husband, beautiful and honorable!";
    
        //add comments to list for each video
        vid1._commentList.Add(vid1Com1);
        vid1._commentList.Add(vid1Com2);
        vid1._commentList.Add(vid1Com3);

        vid2._commentList.Add(vid2Com1);
        vid2._commentList.Add(vid2Com2);
        vid2._commentList.Add(vid2Com3);

        vid3._commentList.Add(vid3Com1);
        vid3._commentList.Add(vid3Com2);
        vid3._commentList.Add(vid3Com3);

        //add each video to videoList
        videoList.Add(vid1);
        videoList.Add(vid2);
        videoList.Add(vid3);

        foreach (Video video in videoList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }  
    
    }
}