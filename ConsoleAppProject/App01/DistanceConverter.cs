using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This is a console app to convert distance from one unit to another
    /// </summary>
    /// <author>
    /// Phill Horrocks version 0.2
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        private double metres;
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        public void MilesToFeet()
        {
            OutputHeader("Convert miles to feet...");
            InputMiles();
            CalculateFeet();
            OutputMiles();
        }
        public void FeetToMiles()
        {
            OutputHeader("Convert feet to miles...");
            InputFeet();
            CalculateMiles();
            OutputFeet();
        }

        public void MilesToMetres()
        {
            OutputHeader("Convert miles to metres...");
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }

        /// <summary>
        /// Ask the user to input the miles
        /// Input miles as a double
        /// </summary>
        /// 
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Ask the user for the number of feet.
        /// </summary>
        private void InputFeet()
        {
            Console.Write("Please enter the number of feet: ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        
        /// <summary>
        /// Ask the user for the number of metres.
        /// </summary>
        private void InputMetres()
        {
            Console.Write("Please enter the number of metres to convert to miles > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
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
