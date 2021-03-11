using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();
        private readonly StudentGrades studentGrades = new StudentGrades();

        private int[] TestMarks;
        private int[] StatsMarks;

        public TestStudentGrades()
        {
            TestMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
            StatsMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            // 1. Arrange
            Grades expectedGrade = Grades.F;
            // 2. Act
            Grades actualGrade = converter.ConvertToGrade(0);
            // 3. Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            // 1. Arrange
            Grades expectedGrade = Grades.F;
            // 2. Act
            Grades actualGrade = converter.ConvertToGrade(39);
            // 3. Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            // 1. Arrange
            converter.Marks = TestMarks;
            double expectedMean = 55.0;
            // 2. Act
            converter.CalculateStats();
            // 3. Assert
            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            // 1. Arrange
            studentGrades.Marks = StatsMarks;
            int expectedMin = 10;
            // 2. Act
            studentGrades.CalculateMin();
            // 3. Assert
            Assert.AreEqual(expectedMin, studentGrades.Min);
        }

        [TestMethod]
        public void TestCalculateMax()
        {
            // 1. Arrange
            studentGrades.Marks = StatsMarks;
            int expectedMax = 100;
            // 2. Act
            studentGrades.CalculateMax();
            // 3. Assert
            Assert.AreEqual(expectedMax, studentGrades.Max);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            // 1. Arrange
            converter.Marks = StatsMarks;
            bool expectedProfile = false;

            // 2. Act
            converter.CalculateGradeProfile();
            expectedProfile = ((studentGrades.GradeProfile[0] == 3) &&
                               (studentGrades.GradeProfile[1] == 1) &&
                               (studentGrades.GradeProfile[2] == 1) &&
                               (studentGrades.GradeProfile[3] == 1) &&
                               (studentGrades.GradeProfile[4] == 4));
            // 3. Assert
            Assert.IsTrue(expectedProfile);
        }

    }
}
