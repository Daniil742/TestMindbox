using TestMindboxLibrary;

namespace TestMindboxLibraryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            var triangle = new Triangle(a, b, c);
            var actual = triangle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }
    }
}