namespace TestMindboxLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius) => Radius = radius;

        public override double CalculateArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
    }
}
