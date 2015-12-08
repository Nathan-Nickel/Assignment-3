using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assign3_triangle;

namespace TriangleTests
{
    [TestClass]
    public class myTriangleTests
    {
        //getHypotenuse
        [TestMethod]
        public void goodTestHypotenuse()
        {
            double answer = 0;
            double sideA = 5;
            double sideB = 3;
            double estimatedAnswer = 0;
            Triangle myTri = new Triangle();
            answer = myTri.getHypotenuse(sideA, sideB);
            estimatedAnswer = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            Assert.IsTrue(answer == estimatedAnswer);
        }

        [TestMethod]
        public void zeroTestHypotenuse()
        {
            double answer = 0;
            double sideA = 0;
            double sideB = 0;
            double estimatedAnswer = 0;
            Triangle myTri = new Triangle();
            answer = myTri.getHypotenuse(sideA, sideB);
            estimatedAnswer = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            Assert.IsTrue(answer == estimatedAnswer);
        }

        [TestMethod]
        public void boothBadTestHypotenuse()
        {
            double answer = 0;
            double sideA = -5;
            double sideB = -3;
            string threwException = "";
            try
            {
                Triangle myTri = new Triangle();
                answer = myTri.getHypotenuse(sideA, sideB);
            }
            catch (Exception ex)
            {
                threwException = ex.Message;
            }

            Assert.IsTrue(threwException == "both inputs were less than 0: " + sideA + ", " + sideB && answer == 0);
        }

        [TestMethod]
        public void firstBadTestHypotenuse()
        {
            double answer = 0;
            double sideA = -5;
            double sideB = 3;
            string threwException = "";
            try
            {
                Triangle myTri = new Triangle();
                answer = myTri.getHypotenuse(sideA, sideB);
            }
            catch (Exception ex)
            {
                threwException = ex.Message;
            }

            Assert.IsTrue(threwException == "first input was less than 0: " + sideA && answer == 0);
        }

        [TestMethod]
        public void secondBadTestHypotenuse()
        {
            double answer = 0;
            double sideA = 5;
            double sideB = -3;
            string threwException = "";
            try
            {
                Triangle myTri = new Triangle();
                answer = myTri.getHypotenuse(sideA, sideB);
            }
            catch (Exception ex)
            {
                threwException = ex.Message;
            }

            Assert.IsTrue(threwException == "second input was less than 0: " + sideB && answer == 0);
        }

        //getArea
        [TestMethod]
        public void goodTestArea()
        {
            double answer = 0;
            double sideA = 5;
            double sideB = 3;
            double expectedArea = 0;

            Triangle myTri = new Triangle();
            answer = myTri.getArea(sideA, sideB);

            expectedArea = (sideA * sideB) * .5;

            Assert.IsTrue(answer == expectedArea);
        }

        [TestMethod]
        public void zeroTestArea()
        {
            double answer = 0;
            double sideA = 0;
            double sideB = 0;
            double expectedArea = 0;

            Triangle myTri = new Triangle();
            answer = myTri.getArea(sideA, sideB);

            expectedArea = (sideA * sideB) * .5;

            Assert.IsTrue(answer == expectedArea);
        }

        [TestMethod]
        public void firstBadTestArea()
        {
            double answer = 0;
            double sideA = -5;
            double sideB = 3;
            string threwException = "";

            Triangle myTri = new Triangle();


            try
            {
                answer = myTri.getArea(sideA, sideB);
            }
            catch (Exception ex)
            {
                threwException = ex.Message;
            }

            Assert.IsTrue(threwException == "first input was less than 0: " + sideA && answer == 0);
        }

        [TestMethod]
        public void secondBadTestArea()
        {
            double answer = 0;
            double sideA = 5;
            double sideB = -3;
            string threwException = "";

            Triangle myTri = new Triangle();


            try
            {
                answer = myTri.getArea(sideA, sideB);
            }
            catch (Exception ex)
            {
                threwException = ex.Message;
            }

            Assert.IsTrue(threwException == "second input was less than 0: " + sideB && answer == 0);
        }

        [TestMethod]
        public void bothBadTestArea()
        {
            double answer = 0;
            double sideA = -5;
            double sideB = -3;
            string threwException = "";

            Triangle myTri = new Triangle();


            try
            {
                answer = myTri.getArea(sideA, sideB);
            }
            catch (Exception ex)
            {
                threwException = ex.Message;
            }

            Assert.IsTrue(threwException == "both inputs were less than 0: " + sideA + ", " + sideB && answer == 0);
        }

        //getMissingAngle
        [TestMethod]
        public void goodTestAangle()
        {
            double answer = 0;
            double angleA = 50;
            double angleB = 47;
            double expectedAngle = 0;

            Triangle myTri = new Triangle();
            answer = myTri.getAngle(angleA, angleB);

            expectedAngle = 180 - (angleA + angleB);

            Assert.IsTrue(answer == expectedAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSideException), "inputs did not add up to at least 90: 0, 0")]
        public void zeroTestAangle()
        {
            double answer = 0;
            double angleA = 0;
            double angleB = 0;

            Triangle myTri = new Triangle();
            answer = myTri.getAngle(angleA, angleB);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSideException), "inputs did not add up to at least 90: -50, 47")]
        public void firstBadTestAangle()
        {
            double answer = 0;
            double angleA = -50;
            double angleB = 47;

            Triangle myTri = new Triangle();
            answer = myTri.getAngle(angleA, angleB);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSideException), "inputs did not add up to at least 90: 50, -47")]
        public void secondBadTestAangle()
        {
            double answer = 0;
            double angleA = 50;
            double angleB = -47;

            Triangle myTri = new Triangle();
            answer = myTri.getAngle(angleA, angleB);
        }
    }
}
