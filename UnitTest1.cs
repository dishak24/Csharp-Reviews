using Review3;
using System.Runtime.CompilerServices;

namespace NUnitTesting
{
    public class Tests
    {
        private CalculatorTesting calculator;
        private StringPalindromeTesting palindrome;


        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorTesting();
            palindrome = new StringPalindromeTesting();
        }

        [Test]
        public void TestAddition()
        {
            //Arrange
            int num1 = 60;
            int num2 = 20;
            int expected = 80;

            //Act
            var actual = calculator.Add(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void TestSubtract()
        {
            //Arrange
            int num1 = 60;
            int num2 = 20;
            int expected = 40;

            //Act
            var actual = calculator.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestMultiply()
        {
            //Arrange
            int num1 = 60;
            int num2 = 20;
            int expected = 1200;

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestDivide()
        {
            //Arrange
            int num1 = 60;
            int num2 = 20;
            int expected = 3;

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestWrongString()
        {
            //Arrange
            string name = "disha";
            bool expected = false;

            //Act
            var actual = palindrome.PalindromString(name);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [Test]
        public void TestCorrectString()
        {
            //Arrange
            string name = "madam";
            bool expected = true;

            //Act
            var actual = palindrome.PalindromString(name);

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