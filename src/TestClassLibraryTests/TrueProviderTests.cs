using TestClassLibrary;

namespace TestClassLibraryTests
{
    [TestClass]
    public class TrueProviderTests
    {
        [TestMethod]
        public void GetTrue_ReturnsTrue()
        {
            // Arrange
            var trueProvider = new TrueProvider();

            // Act
            var trueValue = trueProvider.GetTrue();

            // Assert
            Assert.IsTrue(trueValue);
        }

        [TestMethod]
        public void GetTrue_DoesNotReturnsFalse()
        {
            // Arrange
            var trueProvider = new TrueProvider();

            // Act
            var trueValue = trueProvider.GetTrue();

            // Assert
            Assert.AreNotEqual(false, trueValue);
        }
    }
}