using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

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
    }
}
