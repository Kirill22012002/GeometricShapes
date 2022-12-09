using GeometricShapes;

namespace GeometricShapesTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetPerimeter()
        {
            // Arrange 
            double radius = 23.4;
            double expected = 146.952;
            var circle = new Circle(radius);

            // Act
            var result = circle.GetPerimeter();

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetArea()
        {
            // Arrange 
            double radius = 4.0;
            double expected = 50.24;
            var circle = new Circle(radius);

            // Act 
            var result = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}