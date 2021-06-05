using System;
using System.Collections.Generic;

namespace Midterm
{
    class Program
    {
        static void Main()
        {
            string response = "";
            List<User> userList = new List<User>();
            List<Comment> commentList = new List<Comment>();

            while (response != "5")
            {
                Console.WriteLine("1. User");
                Console.WriteLine("2. Comment");
                Console.WriteLine("3. List of Users");
                Console.WriteLine("4. List of Comments");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");
                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User user = new User();
                        user.Email = "esteban@anypage.com";
                        user.Password = "pasword";
                        user.UserId = 1;
                        user.UserName = "Esteban";

                        userList.Add(user);

                        Console.WriteLine("You have created a user");
                        break;

                    case "2":
                        Comment myComment = new Comment();
                        myComment.CommentId = 1;
                        myComment.TheComment = "Hello";

                        commentList.Add(myComment);

                        Console.WriteLine("You have created a comment");
                        break;

                    case "3":
                        Console.WriteLine("List of users created:");

                        foreach(var insideUser in userList)
                        {
                            Console.WriteLine("User's Email: " + insideUser.Email);
                            Console.WriteLine("User's password: " + insideUser.Password);
                            Console.WriteLine("User's id: " + insideUser.UserId);
                            Console.WriteLine("User's name: " + insideUser.UserName);
                        }
                        break;

                    case "4":
                        Console.WriteLine("List of comments created:");

                        foreach (var insideComment in commentList)
                        {
                            Console.WriteLine("Comment Id: " + insideComment.CommentId);
                            Console.WriteLine("The Comment is: " + insideComment.TheComment);
                        }
                        break;
                }
            }
        }

        public class User
        {
            public User()
            {
            }

            public string Email { get; set; }

            public string UserName { get; set; }

            public string Password { get; set; }

            public int UserId { get; set; }
        }

        public class Comment
        {
            public Comment()
            {
            }

            public string TheComment { get; set; }

            public int CommentId { get; set; }
        }
    }
}





