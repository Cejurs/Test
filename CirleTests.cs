using FigureLibrary.Figures;

namespace Tests
{
    public class CirleTests
    {
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, 28.274)]
        [TestCase(10, 314.159)]
        public void CirleArea(double radius, double expected)
        {
            var cirle = new Cirle(radius);
            var area = Math.Round(cirle.CalculateArea(), 3);
            Assert.That(area, Is.EqualTo(expected));
        }
    }
}
