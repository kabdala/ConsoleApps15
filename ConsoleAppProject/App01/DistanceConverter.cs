using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This is a console app to convert distance from one unit to another
    /// It will prompt the user for a distance in one unit (fromUnit) to
    /// be converted into another unit (toUnit)
    /// </summary>
    /// <author>
    /// Phill Horrocks version 0.5
    /// </author>
    public class DistanceConverter
    {
        // More generalised variables
        private double fromDistance;
        private double toDistance;
        private string fromUnit;
        private string toUnit;

        // Conversions
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        // Strings for units
        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        public void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }
        public void ConvertDistance()
        {
            OutputHeader();
            fromUnit = SelectUnit(" Please select the 'from' distance unit: ");
            toUnit = SelectUnit(" Please select the 'to' distance unit: ");

            Console.WriteLine($"\n Convert {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit}: ");
            CalulateDistance();
            OutputDistance();
        }

        private void CalulateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoices(choice);
            Console.WriteLine($"\n You have selected {unit}");
            return unit;
        }

        private static string ExecuteChoices(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET}");
            Console.WriteLine($"2. {METRES}");
            Console.WriteLine($"3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
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
        /// Output header to the user
        /// </summary> 
        private void OutputHeader()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     Convert units of distance      ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         by Phill Horrocks          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-");
        }


    }
}
