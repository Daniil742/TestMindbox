using TestMindboxLibrary;

namespace TestMindboxLibraryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            double r = 4;
            double expected = 50.26548245743669;

            var circle = new Circle(r);
            var actual = circle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }
    }
}
