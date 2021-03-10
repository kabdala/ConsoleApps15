using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{

    /// <summary>
    /// This is a small app to store, calculate and display
    /// student grades. It uses an SQL database to hold the
    /// data
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
                "Ivor", "Keyop", "Jason",
                "Tiny", "Princess", "Mark",
                "Zark"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
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
            else
            {
                return Grades.B;
            }
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
    }
}
