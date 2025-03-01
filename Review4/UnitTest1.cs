using Review4;

namespace TestingReview4
{
    public class Tests
    {
        private BubbleSortTest bubbleSort;
        private UserRegistration user;
        private UserRegistrationValidation validation;
        [SetUp]
        public void Setup()
        {
            bubbleSort = new BubbleSortTest();
            user = new UserRegistration();
            validation = new UserRegistrationValidation();
        }

        [Test]
        public void BubbuleSortTest()
        {
            //arrange
            int[] input = { 70, 30, 80, 10, 50, 20, 60, 40 };
            int[] expected = { 10, 20, 30, 40, 50, 60, 70, 80 };

            //act
            int[] originalResult = bubbleSort.SortArray(input);

            //assert
            Assert.AreEqual(expected, originalResult);
        }

        [Test]
        public void ValidateDataTrue()
        {
            //arrange
            var input = new UserRegistration() { Name = "Disha", Age = 23, Email = "disha@gmail.com" };
            bool expected = true;

            //act
            var actual = validation.Validate();

        }

        [Test]
        public void ValidateDataFalse()
        {
            //arrange
            var input = new UserRegistration() { Name = "D", Age = 18, Email = "gmail" };
            bool expected = false;

            //act
            var actual = validation.Validate();

        }






        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}