﻿using System;
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
            else
            {
                return Grades.A;
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
        }

        public void OutputGradeProfile()
        {
            Grades grade = Grades.X;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percent = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percent}% Count {count}");
                grade++;
            }

            Console.WriteLine();

        }

    }
}
