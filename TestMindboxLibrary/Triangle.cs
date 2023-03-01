namespace TestMindboxLibrary
{
    public class Triangle : Figure
    {
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double CSide { get; set; }

        public Triangle(double a, double b, double c)
        {
            (ASide, BSide, CSide) = (a, b, c);

            if ((ASide + BSide > CSide) &&
                (ASide + CSide > BSide) &&
                (BSide + CSide > ASide) &&
                ASide > 0 &&
                BSide > 0 &&
                CSide > 0)
            {
                if (ASide * ASide + BSide * BSide == CSide * CSide)
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }

        }

        public override double CalculateArea()
        {
            var halfMeter = GetPerimeter() / 2;
            Area = Math.Sqrt(halfMeter * (halfMeter - ASide) * (halfMeter - BSide) * (halfMeter - CSide));
            return base.CalculateArea();
        }

        private double GetPerimeter() => ASide + BSide + CSide;
    }
}
