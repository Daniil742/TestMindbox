namespace TestMindboxLibrary
{
    public abstract class Figure
    {
        public double Area { get; set; }

        public virtual double CalculateArea()
        {
            return Area;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Площадь: {Area}");
        }
    }
}
