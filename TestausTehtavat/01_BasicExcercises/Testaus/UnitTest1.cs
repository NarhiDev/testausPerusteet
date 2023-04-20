using Tehtävä_1;

namespace Testaus
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Remainder_OnProperValues_ReturnsRemainder()
        {
            Mathematics mat = new Mathematics();

            //Arrange
            int num1 = 2;
            int num2 = 1;
            int expectednum = 1;

            //Act
            int returnednum = mat.Remainder(num1, num2);

            //Assert
            Assert.AreEqual(expectednum, returnednum);
        }

        [TestMethod]
        public void Remainder_IsNotNull_ReturnsRemainder()
        {
            Mathematics mat = new Mathematics();

            //Arrange
            int num1 = 2;
            int num2 = 1;

            //Act
            int returnednum = mat.Remainder(num1, num2);

            //Assert
            Assert.IsNotNull(returnednum);
        }

        [TestMethod]
        public void Power_OnProperValues_ReturnsPower()
        {
            Mathematics mat = new Mathematics();

            //Arrange
            int num = 4;
            int expectednum = 16;

            //Act
            double returnednum = mat.Power(num);

            //Assert
            Assert.AreEqual(expectednum, returnednum);
        }
        [TestMethod]
        public void Power_IsTrue_ReturnsPower()
        {
            Mathematics mat = new Mathematics();

            //Arrange
            int num = 4;
            int expectednum = 16;

            //Act
            double returnednum = mat.Power(num);

            //Assert
            Assert.IsTrue(returnednum == expectednum);
        }
        public void Square_OnProperValues_ReturnSquare()
        {
            Mathematics mat = new Mathematics();

            //Arrange
            int num = 4;
            int expectednum = 2;

            //Act
            double returnednum = mat.Square(num);

            //Assert
            Assert.AreEqual(expectednum, returnednum);
        }
        public void Square_IntOutOfRange_ThrowsException()
        {
            Mathematics mat = new Mathematics();

            //Arrange
            int num = 4;
            try
            {
                //Act
                double returnednum = mat.Square(num);
                num += int.MaxValue;
            }

            catch
            {
               //Assert
               Assert.ThrowsException<ArgumentOutOfRangeException>(() => mat.Square(num));
            }
         
        }

    } 
}