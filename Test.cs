using FigureLibrary.Figures;

namespace Tests
{
    /// <summary>
    ///  Тест через общий интерфейс IFigure
    /// </summary>
    public class Tests
    {
        public static IEnumerable<TestCaseData> TestCaseData 
        {
          get
          {
               yield return new TestCaseData(new Cirle(3)).Returns(28.274);
               yield return new TestCaseData(new Cirle(10)).Returns(314.159);
               yield return new TestCaseData(new Triangle(4, 3, 5)).Returns(6);
               yield return new TestCaseData(new Triangle(4, 4, 3)).Returns(5.562);
               yield return new TestCaseData(new Triangle(4.5, 4.5, 3.5)).Returns(7.255);

          }
        }
        public void Setup()
        {

        }

        [Test]

        [TestCaseSource(nameof(TestCaseData))]
        public double IFigureArea(IFigure figure)
        {
            return Math.Round(figure.CalculateArea(), 3);
        }
    }
}
