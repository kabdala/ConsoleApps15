using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        private int[] testMarks;

        public TestStudentGrades()
        {
            testMarks = new int[]
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
            converter.Marks = testMarks;
            double expectedMean = 55.0;
            // 2. Act
            converter.CalculateStats();
            // 3. Assert
            Assert.AreEqual(expectedMean, converter.Mean);

        }
    }
}
