using System;

class Program
{
    static void Main(string[] args)
    {


        List<Comment> comments1 = new List<Comment>();

        Comment comment1 = new Comment("Keilla","Nice video!");
        comments1.Add(comment1);
        Comment comment2 = new Comment("Marcos","Very Explanatory.");
        comments1.Add(comment2);
        Comment comment3 = new Comment("Emanuel","Very Interesting");
        comments1.Add(comment3);

        List<Comment> comments2 = new List<Comment>();

        Comment comment4 = new Comment("Karine","Great Video!");
        comments2.Add(comment4);
        Comment comment5 = new Comment("Paulo","I learned a lot you teach well!");
        comments2.Add(comment5);
        Comment comment6 = new Comment("Helton","Thank you, paulo!");
        comments2.Add(comment6);
        List<Comment> comments3 = new List<Comment>();
        Comment comment7 = new Comment("Keilla","Nice video!");
        comments3.Add(comment7);
        Comment comment8 = new Comment("Keilla","Nice video!");
        comments3.Add(comment8);
        Comment comment9 = new Comment("Keilla","Nice video!");
        comments3.Add(comment9);

        List<Video> videosList = new List<Video>();

        Video video1 = new Video("Introduction to IT","kleber",260, comments1);
        videosList.Add(video1);
        Video video2 = new Video("Programming Logic","Helton",420, comments2);
        videosList.Add(video2);
        Video video3 = new Video("Python fundamentals","kevin",610, comments3);
        videosList.Add(video3);
        

        foreach (Video video in videosList ){
            Console.WriteLine($"Video name : {video._title}\nAuthor : {video._author}\nComments : {video.CommentsNumber()}");
            
            foreach (Comment comment in video._comments){
                Console.WriteLine($"{comment._personName}: {comment._commentText}");

            }
    


            Console.WriteLine();
        }
        
    }
}