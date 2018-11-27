using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Calculate.Square.Library
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleSquare()
        {
            Circle circle = new Circle();
            var sqr = circle.square;
            Assert.AreEqual(0, sqr);
        }

        [TestMethod]
        public void CircleSquareValue()
        {
            Circle circle = new Circle(3);
            var trueSquare = Math.PI * Math.Pow(3, 2);
            var sqr = circle.square;
            Assert.AreEqual(trueSquare, sqr);
        }

        [TestMethod]
        public void TriangleSquare()
        {
            Triangle triangle = new Triangle();
            var sqr = triangle.square;
            Assert.AreEqual(0, sqr);
        }

        [TestMethod]
        public void TriangleSquareValues()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var trueSquare = 6;
            var sqr = triangle.square;
            Assert.AreEqual(trueSquare, sqr);
        }

        [TestMethod]
        public void TriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool check = triangle.TriangleCheck();
            Assert.IsTrue(check);
        }

    }
}
