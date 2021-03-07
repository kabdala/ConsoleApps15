﻿using System;
using System.Text;
using ConsoleAppProject.Helpers;
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
        // Basic outline of operations
        // ---------------------------
        // 1. Output the heading of the app
        // 2. Ask user for units, metric or imperial
        // 3. Ask the user for their height
        // 4. Ask the user for their weight
        // 5. Check the BMI and output the appropriate message.
        // 6. Output the BAME message.

        // Setup the variables

        // Imperial
        public double Inches;
        public double Feet;
        public double Stones;
        public double Pounds;

        // Metric
        public double Metres;
        //public double Centimetres; //unused right now
        public double Kilos;

        // Setup the constants - according to the data in the WIKI
        public const double UNDERWEIGHT = 18.5;
        public const double NORMAL_WEIGHT = 24.9;
        public const double OVERWEIGHT = 29.9;
        public const double OBESE_CLASS_1 = 34.9;
        public const double OBESE_CLASS_2 = 39.9;
        public const double OBESE_CLASS_3 = 40.0;

        public const int POUNDS_IN_STONES = 14;
        public const int INCHES_IN_FEET = 12;

        // Reference enumeration class
        public Units Imperial;
        public Units Metric;

        // Set the BMI
        public double BMIValue;

        // Default set to NoWeight
        public BMIWeights WeightClass = BMIWeights.NoWeight;

        /// <summary>
        /// Display the heading, the menu and selection available to
        /// the user. At the end of the condition, output the BMI,
        /// display the BAME message then ask the user if they wish
        /// to run the application again.
        /// </summary>
        public void MainMenu()
        {
            ConsoleHelper.OutputHeading("BMI - Body Mass Index Calculator", 0.8);

            Units unit = ChooseUnits();

            if (unit == Units.Imperial)
            {
                InputImperialUnits();
                CalculateImperialBMI();
            }
            else if (unit == Units.Metric)
            {
                InputMetricUnits();
                CalculateMetricBMI();
            }
            else
            {
                Console.WriteLine("Error. Please select option 1 or 2");
                MainMenu();
            }

            OutputBMI();
            BameMessage();
            RunAgain();
        }

        // Get imperial units from the user
        private void InputImperialUnits()
        {
            // These are aritrary numbers I came up with.
            // Technically, they should be bound by the values in the BMI table in the wiki
            Stones = ConsoleHelper.InputNumber("Please enter your weight in stones: ", 1, 50);
            Pounds = ConsoleHelper.InputNumber("Please enter your weight in pounds: ", 0, 13);
            Feet = ConsoleHelper.InputNumber("Please enter your height in feet: ", 1, 10);
            Inches = ConsoleHelper.InputNumber("Please enter your height in inches: ", 1, 11);
        }

        // Calculate the imperial BMI and store in BMIValue
        private void CalculateImperialBMI()
        {
            // TODO: This seems a bit messy - maybe can be simplified
            double WeightInPounds = (Stones * 14) + Pounds;
            double HeightInInches = (Feet * 12 + Inches);
            BMIValue = ((WeightInPounds / HeightInInches) / HeightInInches) * 703;
        }

        // Get metric units from the user
        private void InputMetricUnits()
        {
            //Min & max values there only to stop users' putting silly amounts in
            Kilos = ConsoleHelper.InputNumber("Please enter your weight in kilograms: ", 1, 200);
            Metres = ConsoleHelper.InputNumber("Please enter your height in metres: ", 1, 300);
        }

        // Calculate the imperial BMI and store in BMIValue
        private void CalculateMetricBMI()
        {
            BMIValue = Kilos / (Metres * Metres);
        }

        // Create the choices of imperial or metric from the emum class
        // then call on the console helper to select
        public Units ChooseUnits()
        {
            Console.WriteLine("Please select your unit system:");

            string[] choices =
            {
                Units.Metric.ToString(),
                Units.Imperial.ToString(),
            };
            int choice = ConsoleHelper.SelectChoice(choices);
            if (choice == 1)
            {
                return Units.Metric;
            }
            else if (choice == 2)
            {
                return Units.Imperial;
            }
            return Units.NoUnit;
        }

        // Check the BMI value, assign the appropriate term from the WeightClass
        // and output the message at the end.
        // TODO: Find out why the StringBuilder does not work as expected
        public void OutputBMI()
        {
            StringBuilder message = new StringBuilder("\n");

            if (BMIValue <= UNDERWEIGHT)
            {
                WeightClass = BMIWeights.Underweight;
            }
            else if (BMIValue <= NORMAL_WEIGHT)
            {
                WeightClass = BMIWeights.Normal;
            }
            else if (BMIValue <= OVERWEIGHT)
            {
                WeightClass = BMIWeights.Overweight;
            }
            else if (BMIValue <= OBESE_CLASS_1)
            {
                WeightClass = BMIWeights.Obese1;
            }
            else if (BMIValue <= OBESE_CLASS_2)
            {
                WeightClass = BMIWeights.Obese2;
            }
            else if (BMIValue <= OBESE_CLASS_3)
            {
                WeightClass = BMIWeights.Obese3;
            }

            Console.WriteLine($"\nYour BMI is: {BMIValue:0.00} and your current weight status is: {WeightClass}");
            //message.Append($"Your BMI is: {BMIValue:0.00} and your current weight status is: {WeightClass}");
        }

        /// <summary>
        /// Output the BAME message at the end
        /// </summary>
        public void BameMessage()
        {
            Console.WriteLine("\n###############");
            Console.WriteLine("### CAUTION ###");
            Console.WriteLine("###############");
            Console.WriteLine("Please be aware that there are possible health factors to be");
            Console.WriteLine("taken into account if you belong to a black, Asian, or other");
            Console.WriteLine("ethnic minority group.");
            Console.WriteLine("\nPlease consult a healthcare professional if you have");
            Console.WriteLine("any concerns.");
        }

        // Ask the user if they wish to run through the app again
        public void RunAgain()
        {
            Console.WriteLine("Would you like to run this app again? (Y/N)");
            String choice = Console.ReadLine();
            if (choice == "y")
            {
                MainMenu();
            }

        }

    }
}
