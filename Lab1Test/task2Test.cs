//using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lab1Test1
{
    [TestClass]
    public class task2Test
    {
        [TestMethod]
        public void TestPerimeterCalculator()
        {

            double sideA = 6;
            double sideB = 4;

            task2.Rectangle testRectangle = new task2.Rectangle(sideA,sideB);


            double actualPerimeter = (sideA + sideB) * 2;

            Assert.AreEqual( testRectangle.Perimeter, actualPerimeter);
        }

        [TestMethod]
        public void TestAreaCalculator()
        {
            double sideA = 6;
            double sideB = 4;

            task2.Rectangle testRectangle = new task2.Rectangle(sideA,sideB);

            double actualArea = (sideA * sideB);
            Assert.AreEqual( testRectangle.Area, actualArea);  
        }

        public void TestZeroSides()
        {
            double sideA = 0;
            double sideB = 0;

            task2.Rectangle testRectangle = new task2.Rectangle(sideA, sideB);

            Assert.AreEqual(testRectangle.Perimeter,0);
            Assert.AreEqual( testRectangle.Area,0);
        }
    }
}


namespace Lab1Test2
{
    using task3;
    [TestClass]

    public class task3Test
    {

        [TestMethod]
        public void PointsDistanceTest()
        {

            Point p1 = new Point(5, 3, "Figure1");
            Point p2 = new Point(4, 2, "Figure1");
            Point p3 = new Point(7, 1, "Figure3");

            double actualDistance = Math.Sqrt(Math.Pow(p1.X - p2.X,2) + Math.Pow(p1.Y - p2.Y,2));

            Figure testFigure = new Figure(p1, p2, p3);

            Assert.AreEqual(actualDistance, testFigure.Length(p1, p2));

        }

        [TestMethod]

        public void PerimeterTest()
        {
            Point p1 = new Point(5, 3, "Figure1");
            Point p2 = new Point(4, 2, "Figure1");
            Point p3 = new Point(7, 1, "Figure3");

            double actualPerimeter = 7.4;

            Figure testFigure = new Figure(p1, p2, p3);

            Assert.AreEqual(actualPerimeter,Math.Round(testFigure.Perimeter,1));  




        }
    }
}