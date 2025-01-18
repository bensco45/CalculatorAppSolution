using NUnit.Framework;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            int a = 6;
            int b = 2;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(3.0));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}
