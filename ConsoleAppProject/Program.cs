using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.App05;
using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Phill Horrocks 22/01/21
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("\n\nBNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("------------------------------------------------");
            //Console.Beep();

            // Create a new instance of the DistanceConverter class
            // and call it converter


            //DistanceConverter converter = new DistanceConverter();

            //converter.ConvertDistance();

            // Create a new instance of the BMI calculator class
            // and call it bmi

            BMI bmi = new BMI();
            bmi.MainMenu();

            //TODO: Need to create a user menu and convert feet to miles and miles to metres
        }
    }
}
