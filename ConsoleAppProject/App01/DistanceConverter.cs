using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This is a console app to convert distance from one unit to another
    /// </summary>
    /// <author>
    /// Phill Horrocks version 0.3
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        private double metres;
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        public void OutputDistance(double fromDistance, string fromUnit, double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }
        public void MilesToFeet()
        {
            OutputHeader("Convert miles to feet...");
            miles = InputDistance("Please enter the number of miles: ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }
        public void FeetToMiles()
        {
            OutputHeader("Convert feet to miles...");
            feet = InputDistance("Please enter the number of feet: ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeader("Convert miles to metres...");
            miles = InputDistance("Please enter the number of miles: ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /// <summary>
        /// General purpose imput method
        /// Ask the user to input a distance unit
        /// Input the unit as a double
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }







        /// <summary>
        /// Calculate the number of feet in miles.
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// Calculate the number of feet in miles.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Calculate the number of miles in metres.
        /// </summary>
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }




        /// <summary>
        /// Output the conversion to the user
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet");
        }

        private void OutputFeet()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres");
        }

        /// <summary>
        /// Output header to the user
        /// </summary> 
        private void OutputHeader(String prompt)
        {
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-");
            Console.WriteLine("     Convert units of distance      ");
            Console.WriteLine("         by Phill Horrocks          ");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-");
            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.WriteLine();
        }


    }
}
