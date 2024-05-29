using System;
using youtube;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video v1 = new Video();
        v1._title = "May 2024 Vlog";
        v1._length = "355";
        v1._author = "Doug Johnson";
        Comment v1c1 = new Comment();
        v1c1._commentName = "Laura Call";
        v1c1._commentText = "I love this channel!";
        Comment v1c2 = new Comment();
        v1c2._commentName = "Debbie Reynolds";
        v1c2._commentText = "1:22 I love his laugh!";
        Comment v1c3 = new Comment();
        v1c3._commentName = "Don Knots";
        v1c3._commentText = "Reminds me of Singin' in the Rain";

        Video v2 = new Video();
        v2._title = "Vader Thoughts";
        v2._length = "578";
        v2._author = "Lord Vader";
        Comment v2c1 = new Comment();
        v2c1._commentName = "Emporer Palpaine";
        v2c1._commentText = "Good work, Lord vader.";
        Comment v2c2 = new Comment();
        v2c2._commentName = "Luke Skywalker";
        v2c2._commentText = "Man I wish I could have shown my father this.";
        Comment v2c3 = new Comment();
        v2c3._commentName = "Han Solo";
        v2c3._commentText = "Laugh it up fuzzball!";

        Video v3 = new Video();
        v3._title = "Michael Scott presents: Michael Scott as Chris Rock";
        v3._length = "755";
        v3._author = "Michael Scott";
        Comment v3c1 = new Comment();
        v3c1._commentName = "Dwight Schrute";
        v3c1._commentText = "Bears, Beats, Battlestar Galactica";
        Comment v3c2 = new Comment();
        v3c2._commentName = "Creed Bratton";
        v3c2._commentText = "Right place, right time.";
        Comment v3c3 = new Comment();
        v3c3._commentName = "Stanley Hudson";
        v3c3._commentText = "Did I stutter?";

        v1._commentList.Add(v1c1);
        v1._commentList.Add(v1c2);
        v1._commentList.Add(v1c3);

        v2._commentList.Add(v2c1);
        v2._commentList.Add(v2c2);
        v2._commentList.Add(v2c3);

        v3._commentList.Add(v3c1);
        v3._commentList.Add(v3c2);
        v3._commentList.Add(v3c3);

        videosList.Add(v1);
        videosList.Add(v2);
        videosList.Add(v3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
        
    }
}