namespace GeometricShapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;
        public override double GetArea()
            => Radius * Radius * 3.14;
        public override double GetPerimeter()
            => Radius * 2 * 3.14;
    }
}
