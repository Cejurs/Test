using FigureLibrary.Figures;

namespace Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3,4,5,12)]
        public void TrianglePerimeter(double a, double b, double c,double expected)
        {
            var triangle = new Triangle(a,b,c);
            Assert.That(triangle.Perimeter, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(4,3,5,6)]
        [TestCase(4,4,3, 5.56215)]
        [TestCase(4.5,4.5,3.5, 7.25512)]
        public void TriangleArea(double a,double b,double c, double expected)
        {
            var triangle = new Triangle(a,b,c);
            var area = Math.Round(triangle.CalculateArea(), 5);
            Assert.That(area, Is.EqualTo(expected));
            
        }
        [Test]
        [TestCase(4,3,5,true)]
        [TestCase(3,3,5,false)]
        [TestCase(3.5,4.5,5.7,false)]
        [TestCase(2.6,2.6,3.677,true)]
        public void isRectangularTest(double a,double b,double c,bool expected)
        {
            var triangle = new Triangle(a,b,c);
            Assert.That(triangle.isRectangular, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0,0,0,"a")]
        [TestCase(1,0,1,"b")]
        [TestCase(1,1,0,"c")]
        public void IncorrectSides(double a,double b,double c,string incorrectSide)
        {
            Assert.That(() =>new Triangle(a,b,c), Throws.TypeOf<ArgumentException>()
                .With.Message.EqualTo($"Incorrect {incorrectSide} side"));
        }

        [Test]
        [TestCase(-1,0,0)]
        [TestCase(3,4,8)]
        public void IncorrectTriagle(double a,double b,double c)
        {
            Assert.That(() => new Triangle(a, b, c), Throws.TypeOf<ArgumentException>()
                .With.Message.EqualTo($"Triangle with such sides doesn't exist"));
        }
    }
}