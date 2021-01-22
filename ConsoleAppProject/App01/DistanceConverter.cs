﻿using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This is a console app to convert distance from one unit to another
    /// </summary>
    /// <author>
    /// Phill Horrocks version 0.1
    /// </author>
    public class DistanceConverter
    {

        private double miles;
        private double feet;
        public const int FEET_IN_MILES = 5280;

        /// <summary>
        /// Main run method
        /// </summary>
        public void Run()
        {
            OutputHeader();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Ask the user to input the miles
        /// Input miles as a double
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Calculate the feet from the miles inputted
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Output header to the user
        /// </summary> 
        private void OutputHeader()
        {
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-");
            Console.WriteLine("       Convert miles to feet        ");
            Console.WriteLine("         by Phill Horrocks          ");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-");
            Console.WriteLine();
        }

        /// <summary>
        /// Output the conversion to the user
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " in feet");
        }

    }
}
