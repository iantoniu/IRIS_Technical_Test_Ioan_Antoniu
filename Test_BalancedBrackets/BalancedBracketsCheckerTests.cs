using Balanced_Brackets;

namespace Test_BalancedBrackets
{
    [TestClass]
    public class BalancedBracketsCheckerTests
    {
        [TestMethod]
        public void TestBalancedBracketsWithCorrectInput()
        {
            Assert.IsTrue(BalancedBracketsChecker.AreBracketsBalanced("[()]{}{()()}"));
        }

        [TestMethod]
        public void TestBalancedBracketsWithIncorrectInput()
        {
            Assert.IsFalse(BalancedBracketsChecker.AreBracketsBalanced("[(])"));
        }

        [TestMethod]
        public void TestBalancedBracketsWithEmptyInput()
        {
            Assert.IsTrue(BalancedBracketsChecker.AreBracketsBalanced(""));
        }

        [TestMethod]
        public void TestBalancedBracketsWithNoBrackets()
        {
            Assert.IsTrue(BalancedBracketsChecker.AreBracketsBalanced("123abc"));
        }

        [TestMethod]
        public void TestBalancedBracketsWithNestedBrackets()
        {
            Assert.IsTrue(BalancedBracketsChecker.AreBracketsBalanced("{[()]}"));
        }

        [TestMethod]
        public void TestBalancedBracketsWithUnbalancedBrackets()
        {
            Assert.IsFalse(BalancedBracketsChecker.AreBracketsBalanced("{[(])}"));
        }

        [TestMethod]
        public void TestBalancedBracketsWithInvalidCharacters()
        {
            Assert.ThrowsException<ArgumentException>(() => BalancedBracketsChecker.AreBracketsBalanced("{[a]}"));
        }
    }
}