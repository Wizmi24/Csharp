using System;
using System.Collections.Generic;

namespace Cwiczenie_16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = new List<string>();
            var post = new Post();

            while (true)
            {
                Console.WriteLine("upvote, downvote a post, count or exit");
                userInput.Add(Console.ReadLine());
                if (userInput[userInput.Count - 1] == "upvote") post.Upvote();
                else if (userInput[userInput.Count - 1] == "downvote") post.Downvote();
                else if (userInput[userInput.Count - 1] == "count") Console.WriteLine("Now post has {0} upvotes", post.Votes());
                else if (userInput[userInput.Count - 1] == "exit") return;
            }
        }

        public class Post
        {
            private string _title;
            private string _description;
            private DateTime _created;
            private int _upvoteCount = 0;

            public Post()
            {
                _title = "Awesome heroes";
                _description = "list of heroes, which saved people";
                _created = DateTime.Now;
            }

            public void Upvote()
            {
                _upvoteCount++;
            }

            public void Downvote()
            {
                _upvoteCount--;
            }
            public int Votes()
            {
                return _upvoteCount;
            }
        }

    }
}
