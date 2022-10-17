using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPosts
{
    public class Post
    {
        public string _title { get; set; }
        public string _content { get; set; }
        public DateTime _publishTime { get; set; }

        int upVotes = 0;
        int downVotes = 0;

        public Post() {
            _title = "Deafault";
            _content = "Default";
            _publishTime = DateTime.Now;
        }
        public Post(string title)
            : this()
        {
            _title = title;
            

        }
        public Post(string title, string content)
            : this()
        {
            _title = title;
            _content = content;
            
        }
        public Post(string title , string content , DateTime dt)
            :this()
        {
            _title = title;
            _content = content;
            _publishTime = dt;
        }


        public void Print()
        {
            Console.WriteLine();
            Console.Write("Title : ");
            Console.Write(_title + "\n");
            Console.Write("Content : ");
            Console.Write(_content + "\n");
            Console.Write("Date : ");
            Console.Write(_publishTime.ToString() + "\n");
            Console.Write("Up votes : ");
            Console.Write(upVotes + "\n");
            Console.Write("Down votes : ");
            Console.Write(downVotes + "\n");
            Console.WriteLine();
        }

        public void Upvote()
        {
            upVotes++;
        }
        public void Downvote()
        {
            downVotes++;
        }


    }
}
