using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tehtävä_1._1_ja_1._2;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Remainder_OnProperValues_ReturnsRemainder()
        {

            //Arrange
            int num1 = 2;
            int num2 = 1;
            int expectednum = 1;

            //Act
            int returnednum = Mathematics.Remainder(num1, num2);

            //Assert
            Assert.AreEqual(expectednum, returnednum);
        }

        [TestMethod]
        public void Remainder_IsNotNull_ReturnsRemainder()
        {

            //Arrange
            int num1 = 2;
            int num2 = 1;

            //Act
            int returnednum = Mathematics.Remainder(num1, num2);

            //Assert
            Assert.IsNotNull(returnednum);
        }

        [TestMethod]
        public void Power_OnProperValues_ReturnsPower()
        {

            //Arrange
            int num = 4;
            int expectednum = 16;

            //Act
            double returnednum = Mathematics.Power(num);

            //Assert
            Assert.AreEqual(expectednum, returnednum);
        }
        [TestMethod]
        public void Power_IsTrue_ReturnsPower()
        {

            //Arrange
            int num = 4;
            int expectednum = 16;

            //Act
            double returnednum = Mathematics.Power(num);

            //Assert
            Assert.IsTrue(returnednum == expectednum);
        }
        public void Square_OnProperValues_ReturnSquare()
        {

            //Arrange
            int num = 4;
            int expectednum = 2;

            //Act
            double returnednum = Mathematics.Square(num);

            //Assert
            Assert.AreEqual(expectednum, returnednum);
        }
        public void Square_IntOutOfRange_ThrowsException()
        {

            //Arrange
            int num = 4;
            try
            {
                //Act
                double returnednum = Mathematics.Square(num);
                num += int.MaxValue;
            }

            catch
            {
                //Assert
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => Mathematics.Square(num));
            }

        }
        [TestMethod]
        public void FindSmallest_GivenListWithOneItem_ReturnsThatItem()
        {
            // Arrange
            List<double> list = new List<double> { 42.0 };

            // Act
            double result = Mathematics.FindSmallest(list);

            // Assert
            Assert.AreEqual(42.0, result);
        }

        [TestMethod]
        public void FindSmallest_GivenListWithMultipleItems_ReturnsSmallestItem()
        {
            // Arrange
            List<double> list = new List<double> { 3.14, 2.71, 1.41, 0.0, -1.0 };

            // Act
            double result = Mathematics.FindSmallest(list);

            // Assert
            Assert.AreEqual(-1.0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindSmallest_GivenEmptyList_ThrowsArgumentException()
        {
            // Arrange
            List<double> list = new List<double>();

            // Act
            Mathematics.FindSmallest(list);

            // Assert
            // Expected exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindSmallest_GivenNullList_ThrowsArgumentException()
        {
            // Arrange
            List<double> list = null;

            // Act
            Mathematics.FindSmallest(list);

            // Assert
            // Expected exception
        }
        [TestMethod]
        public void FindMaxValue_ReturnsMaxValue()
        {

            //Arrange
            List<int> numbers = new List<int>() { 2, 4, 1, 5, 3 };
            int expectedMax = 5;

            //Act
            int returnedMax = Mathematics.FindMaxValue(numbers);

            //Assert
            Assert.AreEqual(expectedMax, returnedMax);
        }

        [TestMethod]
        public void FindMaxValue_IsNotNull_ReturnsMaxValue()
        {
            ;

            //Arrange
            List<int> numbers = new List<int>() { 2, 4, 1, 5, 3 };

            //Act
            int returnedMax = Mathematics.FindMaxValue(numbers);

            //Assert
            Assert.IsNotNull(returnedMax);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMaxValue_ListIsEmpty_ThrowsArgumentException()
        {

            //Arrange
            List<int> numbers = new List<int>();

            //Act
            int returnedMax = Mathematics.FindMaxValue(numbers);

            //Assert
            // Expected exception

        }
        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void FindMaxValue_ListIsNull_ThrowsArgumentException()
        {

            //Arrange
            List<int> numbers = null;

            //Act
            int returnedMax = Mathematics.FindMaxValue(numbers);

            //Assert
            // Expected exception
        }

        [TestMethod]
        public void CalculateAverage_ReturnsCorrectValue()
        {
            // Arrange
            List<float> numbers = new List<float> { 1.0f, 2.0f, 3.0f, 4.0f };
            float expected = 2.5f;

            // Act
            float result = Mathematics.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateAverage_ListIsNull_ThrowsArgumentException()
        {
            // Arrange
            List<float> numbers = null;

            // Act
            Mathematics.CalculateAverage(numbers);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateAverage_ListIsEmpty_ThrowsArgumentException()
        {
            // Arrange
            List<float> numbers = new List<float>();

            // Act
            Mathematics.CalculateAverage(numbers);
        }

    }
}
