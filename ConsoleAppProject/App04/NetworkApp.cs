using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("NetworkApp", 0.1);

            string[] choices = new string[]
            {
                "Post a message",
                "Post an image",
                "Display all posts",
                "Display posts by date",
                "Display posts by author",
                "Remove a post",
                "Add a comment",
                "Like a post",
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
                    case 8: LikePost(); break;

                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }

        private void PostImage()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void LikePost()
        {
            throw new NotImplementedException();
        }

        

        

        



       
    }
}
