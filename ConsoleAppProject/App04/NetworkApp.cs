using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// Main app menu to call the various other methods
    /// within the scope of this app
    /// </summary>
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        private int postCount = 0;

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("NetworkApp", 0.1);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("\tCurrent Date: "+dateTime.ToLongDateString());
            Console.WriteLine("\tCurrent Time: "+dateTime.ToLongTimeString());
            Console.WriteLine("\t-=-=-=-=-=-=-=-=-=-=-=-=-\n");

            string[] choices = new string[]
            {
                "Post a message",
                "Post an image",
                "Display all posts",
                "Display posts by date",
                "Display posts by author",
                "Remove a post",
                "Add a comment",
                "Like or Unlike a post",
                "Quit the app"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DisplayByDate(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: RemovePost(); break;
                    case 7: AddComment(); break;
                    case 8: LikeOrUnlikePost(); break;

                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        /// <summary>
        /// Given that we're going to be asking for an author name throughout
        /// this app, it makes sense to implement a specific method for
        /// getting the 'author' that we can re-use.
        ///
        /// </summary>
        public string EnterAuthorName()
        {
            Console.WriteLine("# To post, please enter your name: ");
            string postAuthor = Console.ReadLine();
            return postAuthor; // pass the string back out
        }

        /// <summary>
        /// Add a post message
        ///
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("** POST A MESSAGE **");
            postCount++;
            string message = Console.ReadLine();
            
            // TODO: Need to have some form of ID per message so we can remove it later
            // TODO: Need an input method to read an author name
        }

        private void PostImage()
        {
            ConsoleHelper.OutputTitle("** POST AN IMAGE **");
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }
        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle("** REMOVE A POST **");
            //Console.WriteLine("\n Please enter the ID of the post you wish to remove: ");
            // int id = (int)ConsoleHelper.InputNumber("Please enter the post ID number: ", 1 Post.GetNumberOfPosts());
            // TODO: Need to reference a post ID in order to delete it
            // throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void LikeOrUnlikePost()
        {
            ConsoleHelper.OutputTitle("** LIKE OR UNLIKE A POST **");
            // Display a list of posts with ID's before choosing?
            Console.WriteLine("Would you like to (L)ike or (U)nlike a post?");
            Console.WriteLine("L / U");
            
            // throw new NotImplementedException();
        }

    }
}
