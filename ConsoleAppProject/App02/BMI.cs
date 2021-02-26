using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This program should ask the user to select their measurement
    /// system: imperial or metric then prompt them to enter their
    /// height and weight. The system will output their BMI and
    /// any message of warning to bame groups.
    /// </summary>
    /// <author>
    /// Phill Horrocks version 0.2
    /// </author>
    public class BMI
    {
        // 0. Output the heading of the app
        // 1. Ask user for units, metric or imperial
        // 2. Ask the user for their height
        // 3. Ask the user for their weight
        // 4. Check the BMI and output the appropriate message.
        // 5. Output the BAME message.

        // Setup the variables
        private double inches;
        private double feet;
        private double stones;
        private double pounds;
        private double metres;
        private double kilos;
        private double BMIindex;

        public const int POUNDS_IN_STONES = 14;
        public const int INCHES_IN_FEET = 12;

        // Setup the constants - according to the data in the WIKI
        public const double UNDERWEIGHT = 18.5;
        public const double NORMAL_WEIGHT = 24.9;
        public const double OVERWEIGHT = 29.9;
        public const double OBESE_CLASS_1 = 34.9;
        public const double OBESE_CLASS_2 = 39.9;
        public const double OBESE_CLASS_3 = 40.0;

        private Units Imperial;
        private Units Metric;

        // Output the heading at the beginning
        public void ShowHeading()
        {
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\tBMI Calculator     ");
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~");
        }

        // Ask the user to pick their unit measurements
        // Metric or imperial
        public void ChooseUnit()
        {
            Console.WriteLine("\n\tPlease select a unit of measurement");
            Console.WriteLine("\t1. Metric (metres and kilograms");
            Console.WriteLine("\t2. Imperial (feet and pounds");
            Console.WriteLine();
            Console.WriteLine("Please make your choice (1 or 2");
            string input = Console.ReadLine();
        }

        // Need to insert logic for menu


        // Ask the user for the metric measurements

        public void InputMetric()
        {
            // Enter height in metres
            Console.WriteLine("\n\tPlease enter your height in metres:");
            string HeightInMetres = Console.ReadLine();

            // Enter weight in kilos
            Console.WriteLine("\n\tPlease enter your weight in kilograms:");
            string WeightInKilos = Console.ReadLine();
        }


        // Ask the user for the imperial measurements

        public void InputImperial()
        {
            // Enter height in feet & inches
            Console.WriteLine("\n\tPlease enter your height in feet:");
            string HeightInFeet = Console.ReadLine();

            Console.WriteLine("\n\tPlease enter your height in inches:");
            string HeightInInches = Console.ReadLine();


            // Enter weight in stones & pounds
            Console.WriteLine("\n\tPlease enter your weight in stones:");
            string WeightInStones = Console.ReadLine();

            Console.WriteLine("\n\tPlease enter your weight in pounds:");
            string WeightInPounds = Console.ReadLine();
        }


        // Calculate BMI based on metric measurments
        public void CalculateMetric()
        {
            // BMI = (weight in kg) / (height in metres)2
            MetricBMI = WeightInKilos / (HeightInMetres * HeightInMetres);

        }

        // Calculate BMI based on imperial measurements
        public void CalculateImperial()
        {
            // BMI = (weight in pounds) x 703 / (height in inches)2
        }

        // Output the BMI

        public void OutputBMI()
        {
            Console.WriteLine("Your BMI is: ");
        }

        // Display any warning message based on BMI

        public void BMIMessage()
        {
            Console.WriteLine("BMI Message goes here");
        }

        // Display any warning message based on BAME group

        public void BameMessage()
        {
            Console.WriteLine("Special message to BAME groups");
        }

        // Ask the user if they wish to run the app again (loop)


        
        /*
        public void GetInput ()
        {
            // How to get input on one line
            Console.Write("Make your choice: ");
            string menuChoice = Console.ReadLine();

            // Replacement in text
            Console.WriteLine($"You entered {variableName} and {anotherVariable} so great!");
            // or
            Console.WriteLine("You entered {0} and {1} so great!",variableName, anotherVariable);


        }
        */

        // Reusable methods go here 
    }
}
