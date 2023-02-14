using KramerMethodEquation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KramerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SolveSystem_2LinesWithoutSolution_CorrectResult()
        {
            // Arrange
            double a1 = 1;
            double b1 = 2;
            double c1 = 3;
            double a2 = 1;
            double b2 = 2;
            double c2 = 4;

            // Act
            var result = Program.SolveSystem(a1, b1, c1, a2, b2, c2);

            // Assert
            Assert.AreEqual("Система линейных уравнений не имеет решений", result[0]);
        }
    }
}
