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
        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        // Conversions
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        // Strings for units
        //public const string FEET = "Feet";
        //public const string MILES = "Miles";
        //public const string METRES = "Metres";

        public DistanceConverter()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;
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
            if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
        }

        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            DistanceUnits unit = ExecuteChoices(choice);
            Console.WriteLine($"\n You have selected {unit}");
            return unit;
        }

        private DistanceUnits ExecuteChoices(string choice)
        {
            if (choice.Equals("1"))
            {
                return DistanceUnits.Feet;
            }
            else if (choice == "2")
            {
                return DistanceUnits.Metres;
            }
            else if (choice.Equals("3"))
            {
                return DistanceUnits.Miles;
            }

            return DistanceUnits.NoUnit;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {DistanceUnits.Feet}");
            Console.WriteLine($"2. {DistanceUnits.Metres}");
            Console.WriteLine($"3. {DistanceUnits.Miles}");
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
