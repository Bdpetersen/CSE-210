using System;

class Program
{
   static void Main(string[] args)
        {
            // 3. Create 3-4 Videos
            Video video1 = new Video("Understanding Abstraction", "CodeWithCaleb", 300);
            Video video2 = new Video("C# For Beginners", "DevWorld", 600);
            Video video3 = new Video("Encapsulation Explained", "CodeWithCaleb", 450);

            // 4. Add 3-4 Comments to each video
            video1.AddComment(new Comment("User123", "Great explanation!"));
            video1.AddComment(new Comment("CoderGirl", "I finally understand abstraction."));
            video1.AddComment(new Comment("DevGuy", "Could you do a video on Inheritance next?"));

            video2.AddComment(new Comment("NewbieCoder", "This was a bit too fast for me."));
            video2.AddComment(new Comment("ProGrammar", "Excellent syntax usage."));
            video2.AddComment(new Comment("LearningDaily", "Thanks for the video."));

            video3.AddComment(new Comment("OopFan", "Encapsulation is vital!"));
            video3.AddComment(new Comment("SecureDev", "Keeps the data safe."));
            video3.AddComment(new Comment("JavaLover", "Similar to Java beans."));
            video3.AddComment(new Comment("Pythonista", "Good stuff."));

            // 5. Put videos in a list
            List<Video> videos = new List<Video>();
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // 6. Iterate through the list and display info
            foreach (Video v in videos)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Title: {v._title}");
                Console.WriteLine($"Author: {v._author}");
                Console.WriteLine($"Length: {v._length} seconds");
                Console.WriteLine($"Number of Comments: {v.GetNumberOfComments()}");
                
                Console.WriteLine("Comments:");
                foreach (Comment c in v.GetComments())
                {
                    Console.WriteLine($"- {c._name}: {c._text}");
                }
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine(); 
            }
        }
}