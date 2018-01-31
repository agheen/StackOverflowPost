using System;

namespace StackOverflowPost
{
    class Post
    {
        public Post()
        {
            Created = DateTime.Now;
            Value = 0;
        }

        public DateTime Created { get; set; }
        public int Value { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Info()
        {
            Console.WriteLine("Created: " + Created);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Descrption: " + Description);
            Console.WriteLine("Value: " + Value);
        }

        public void UpVote()
        {
            Value += 1;
        }

        public void DownVote()
        {
            Value -= 1;
        }

    }
}
