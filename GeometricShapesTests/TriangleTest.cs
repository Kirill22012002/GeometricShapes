using GeometricShapes;

namespace GeometricShapesTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetPerimeter()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expected = 12;

            // Act 
            var result = triangle.GetPerimeter();

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetArea()
        {
            // Arrange 
            var triangle = new Triangle(3, 4, 5);
            var expected = 6;

            // Act 
            var result = triangle.GetArea();

            // Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
