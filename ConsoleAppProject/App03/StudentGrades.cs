using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{

    /// <summary>
    /// This is a small app to store, calculate and display
    /// student grades. It uses an SQL database to hold the
    /// data
    /// 
    /// Outline of program:
    /// 1. Input marks
    /// 2. Output marks
    /// 3. Output stats
    /// 4. Output grade profile
    /// 5. Quit
    /// </summary>
    public class StudentGrades
    {
        // Setup the application constants

        public const int NoGrade = 0;
        public const int LowGradeD = 40;
        public const int LowGradeC = 50;
        public const int LowGradeB = 60;
        public const int LowGradeA = 70;
        public const int HighGrade = 100;

        // Setup the main properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // Main constructor

        // Populate the Students string with some
        // sample student names
        public StudentGrades()
        {
            Students = new string[]
            {
                "Rod", "Jane", "Freddie",
                "Zoltar", "Keyop", "Jason",
                "Tiny", "Princess", "Mark",
                "Zark"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// Output a heading on the console app version
        /// using the consolehelper
        /// </summary>
        public void OutputHeading()
        {
            ConsoleHelper.OutputHeading("Simple Student Mark App",0.1);
            SelectChoice();
        }


        /// <summary>
        /// Get the user to enter marks from 0 to 100 for
        /// each of the 10 students
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Dispay all the students along with their marks
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert a student grade from F to A
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= NoGrade && mark < LowGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowGradeD && mark < LowGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowGradeC && mark < LowGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowGradeB && mark < LowGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowGradeA && mark <= HighGrade)
            {
                return Grades.A;
            }
            return Grades.N;
        }

        /// <summary>
        /// Calculate and output min, max and mean marks for
        /// all 10 students
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;
            foreach (int mark in Marks)
            {
                total = total + mark;
            }
            Mean = total / Marks.Length;
        }

        public void CalculateMin()
        {
            Min = Marks[0];
            Max = Marks[0];

            double total = 0;
            foreach (int mark in Marks)
            {
                if (mark > Max) Max = mark;
                if (mark < Min) Min = mark;
                Mean = total / Marks.Length;
            }
        }

        public void CalculateMax()
        {
            Min = Marks[0];
            Max = Marks[9];

            double total = 0;
            foreach (int mark in Marks)
            {
                if (mark > Max) Max = mark;
                if (mark < Min) Min = mark;
                Mean = total / Marks.Length;
            }
        }

        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }

        public void OutputGradeProfile()
        {
            // Start with the default grade of N (NA)
            Grades grade = Grades.N;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percent = count * 100 / Marks.Length;
                Console.WriteLine($"\nGrade {grade}\t {percent}% \tCount \t{count}");
                grade++;
            }

            Console.WriteLine();
        }

        public void SelectChoice()
        {
            Console.WriteLine("\n*** Please select one of the following options ***\n");
            string[] choices = { "Enter Marks", "Display Marks",
                                 "Display Stats", "Display Grade Profile", "Quit" };
            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                EnterMarks();
            }
            else if (choice == 2)
            {
                // Display Marks
            }
            else if (choice == 3)
            {
                // Display Stats
            }
            else if (choice == 4)
            {
                // Dispplay Grade Profile
            }
            else if (choice == 5)
            {
                // Quit
            }
            else
            {
                Console.WriteLine("Error. Please select a choice (1-5");
                SelectChoice(); // Loop back to choose again
            }
        }

        /// <summary>
        /// Ask the user for the marks for 10 students
        /// </summary>
        public void EnterMarks()
        {
            Console.WriteLine("Please enter marks: ");
            // Create a loop to enter the 10 students marks
            for(int i = 0; i < Students.Length; i++)
            {
                // Thanks StackOverflow for the 'Cast' reminder 😁
                // Limit the input between min & max marks (0 to 100)
                Marks[i] = (int)ConsoleHelper.InputNumber
                    ($"\nPlease enter the mark for student #"+(i+1)+$" {Students[i]}: ", 0, 100);
            }
            // Now, go back to the main menu
            SelectChoice(); // Loop back to choose again
        }

    }

}
