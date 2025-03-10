using Review5;

namespace NUnitTestReview5
{
    public class Tests
    {

        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            //Arrange
            int num1 = 50;
            int num2 = 5;
            int expected = 55;

            //Act
            var actual = calculator.Add(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestSubtraction()
        {
            //Arrange
            int num1 = 50;
            int num2 = 5;
            int expected = 45;

            //Act
            var actual = calculator.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestMultiplication()
        {
            //Arrange
            int num1 = 50;
            int num2 = 5;
            int expected = 250;

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestDivision()
        {
            //Arrange
            int num1 = 50;
            int num2 = 5;
            int expected = 10;

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}