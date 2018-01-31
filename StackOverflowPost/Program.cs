using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post()
            {
                Title = "Hyperion Review",
                Description = "Hyperion is a 9/10 over-all good read, I recommend"
            };

            var post2 = new Post()
            {
                Title = "Snow Crash Review",
                Description = "SC is just an amazing book. Wowie! What a great read.",
                Created = DateTime.Now.AddDays(5).AddHours(7)
            };

            post1.UpVote();
            post1.UpVote();
            post1.DownVote();
            post1.Info();

        }
    }
}
