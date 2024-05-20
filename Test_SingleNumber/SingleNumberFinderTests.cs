using Single_Number;

namespace Test_SingleNumber
{
    [TestClass]
    public class SingleNumberFinderTests
    {
        [TestMethod]
        public void FindSingleNumber_WithOneElement_ReturnsThatElement()
        {
            // Arrange
            int[] input = { 1 };
            int expected = 1;

            // Act
            int result = SingleNumberFinder.FindSingleNumber(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindSingleNumber_WithMultipleElements_ReturnsSingleElement()
        {
            // Arrange
            int[] input = { 4, 1, 2, 1, 2 };
            int expected = 4;

            // Act
            int result = SingleNumberFinder.FindSingleNumber(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindSingleNumber_WithAllPairsExceptOne_ReturnsSingleElement()
        {
            // Arrange
            int[] input = { 2, 2, 1 };
            int expected = 1;

            // Act
            int result = SingleNumberFinder.FindSingleNumber(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindSingleNumber_WithLargeDataSet_ReturnsSingleElement()
        {
            // Arrange
            int[] input = { 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7 };
            int expected = 7;

            // Act
            int result = SingleNumberFinder.FindSingleNumber(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindSingleNumber_WithNegativeNumbers_ReturnsSingleElement()
        {
            // Arrange
            int[] input = { -1, -1, -2 };
            int expected = -2;

            // Act
            int result = SingleNumberFinder.FindSingleNumber(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}