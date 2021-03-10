using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {

            // 1. Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;

            // 2. Act
            converter.CalculateDistance();
            double expectedDistance = 5280;

            // 3. Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestFeetToMiles()
        {

            // 1. Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 5280;

            // 2. Act
            converter.CalculateDistance();
            double expectedDistance = 1;

            // 3. Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
    }
}
