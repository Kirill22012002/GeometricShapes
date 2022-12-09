namespace GeometricShapes
{
    public class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double GetPerimeter()
        {
            if (IsTriangle())
            {
                return Side1 + Side2 + Side3;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override double GetArea()
        {
            if (IsTriangle())
            {
                var P = GetPerimeter();
                var p = P / 2;

                return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            }
            else
            {
                throw new ArgumentException();
            }
        }

        // Triangle checks
        public bool IsTriangle()
            => Side1 + Side2 > Side3 && Side1 + Side3 > Side2 && Side2 + Side3 > Side1;
        public bool IsRight()
            => IsTriangle() && ((Side1 * Side1) + (Side2 * Side2) == (Side3 * Side3));
        public bool IsIsosceles()
            => IsTriangle() && (Side1 == Side2 || Side2 == Side3 || Side1 == Side3);
        public bool IsEquilateral() 
            => IsTriangle() && Side1 == Side2 && Side2 == Side3;
        public bool IsScalene() 
            => IsTriangle() && (Side1 != Side2 && Side2 != Side3 && Side1 != Side3);
    }
}