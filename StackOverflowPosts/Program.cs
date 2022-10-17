using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPosts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Post>posts = new List<Post>();
            while (true)
            {
                Console.WriteLine("Write number of operation :");
                Console.WriteLine("1. Add Post");
                Console.WriteLine("2. Delete Last Post");
                Console.WriteLine("3. Show post number :");
                Console.WriteLine("4. Show all posts :");
                Console.WriteLine("5. Upvote post number :");
                Console.WriteLine("6. Downvote post number :");
                int choser = Convert.ToInt32(Console.ReadLine());
                switch (choser)
                {
                    case 1:
                        {
                            Console.WriteLine("Write title : ");
                            string title = Console.ReadLine();
                            Console.WriteLine("Write content : ");
                            string content = Console.ReadLine();
                            Console.WriteLine("Write Date : ");
                            string dateStr = Console.ReadLine();
                            DateTime datePublish = Convert.ToDateTime(dateStr);
                            posts.Add(new Post(title, content, datePublish));
                        }
                        break;
                    case 2:
                        {
                            posts.RemoveAt(posts.Count - 1);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Write position of the post :");
                            int pos = Convert.ToInt32(Console.ReadLine());
                            posts[pos].Print();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine();
                            for(int i = 0; i < posts.Count; i++)
                            {
                                Console.WriteLine($"Post number {i} :");
                                posts[i].Print();
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Choose post to upvote ");
                            int upnum = Convert.ToInt32(Console.ReadLine());
                            posts[upnum].Upvote();
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Choose post to downvote ");
                            int downnum = Convert.ToInt32(Console.ReadLine());
                            posts[downnum].Downvote();
                        }
                        break;
                }
            }
        }
    }
}
