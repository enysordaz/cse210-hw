using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        // Video 1 
        Video video1 = new Video(" Lost World of the Maya ", " National Geographic ", 2664);

        Comments video1Comment1 = new Comments(" Belinda ", " Most people don't understand the minds of history-loving people. Thank you Nat Geo, for today I can find answers to my childhood inquiries many people dismiss as inconsequential.");
        Comments video1Comment2 = new Comments(" Tom "," The ancient world is so fascinating. To imagine the cultures and practices we have missed, forgotten, never learned about.");
        Comments video1Comment3 = new Comments(" Fernando ", " Only in the last couple of years have I realized how massive the Maya civilization really was. The likely possibility that there are hundreds of yet to be discovered sites burried inside the vast jungles is astonishing.");

        video1.ListComments(video1Comment1);
        video1.ListComments(video1Comment2);
        video1.ListComments(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video(" The Art of Mayan Cuisine in the Yucatan " , " Munchies ", 1048);

        Comments video2Comment1 = new Comments(" Mario ", " Great episode! I thoroughly enjoyed this one. The Yucatan peninsula has now been added to my must visit list without a doubt!");
        Comments video2Comment2 = new Comments(" Andrea " , " So what i get from this is that tacos have been around for centuries. Makes me appreciate them even more. Thank you ancient peoples!");
        Comments video2Comment3 = new Comments(" Juan " , " Love it. Thank you for sharing this magical experience");

        video2.ListComments(video2Comment1);
        video2.ListComments(video2Comment2);
        video2.ListComments(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video(" 10 Most Amazing Mayan Ruins " , "Touropia" , 813);

        Comments video3Comment1 = new Comments(" Karla" , " Amazing video!! Thanks for sharing and keep creating new vidoes! Have a great day.");
        Comments video3Comment2 = new Comments(" Mary ", " The Earths history is unrivalled! Some wonderful structures!");
        Comments video3Comment3 = new Comments(" Jali " , " I can feel as if I traveled Yucatán…this is a good diversion in such stay home situation. I would like to go there someday.");

        video3.ListComments(video3Comment1);
        video3.ListComments(video3Comment2);
        video3.ListComments(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}