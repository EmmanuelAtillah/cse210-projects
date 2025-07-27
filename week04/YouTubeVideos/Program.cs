using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._author = "Emmanue Atillah";
        video1._title = "Butterfly Trailer";
        video1._length = "900 ";
       
        video1._comment.Add(new Comment(){_name = "iboi", _text = "it gonna be lit"});
        video1._comment.Add(new Comment(){_name = "lighter", _text = "wow"});
        video1._comment.Add(new Comment(){_name = "ghost", _text = "can't wait"});


        Video video2 = new Video();
        video2._author = "Tyler Flinn";
        video2._title = "Cats";
        video2._length = "1200 ";

        video2._comment.Add(new Comment(){_name = "Ellma", _text = "interesting"});
        video2._comment.Add(new Comment(){_name = "Budo", _text = "I never knew"});
        video2._comment.Add(new Comment(){_name = "Robert", _text = "eii."});
  

        Video video3 = new Video();
        video3._author = "Damon salvatore";
        video3._title = "Korean Drama";
        video3._length = "1800 ";
   
        video3._comment.Add(new Comment(){_name = "Bella", _text = "That was unexpected"});
        video3._comment.Add(new Comment(){_name = "Belly", _text = "ohh I see"});
        video3._comment.Add(new Comment(){_name = "lioness", _text = "There it is"});


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);



        foreach (Video video in videos)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"\nVideo Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Video Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");


            foreach (Comment comment in video._comment)
            {
                Console.WriteLine("");
                Console.WriteLine($"Commentor's name: {comment._name}");
                Console.WriteLine($"comment info: {comment._text}");


            }
        }

        



    }
};



