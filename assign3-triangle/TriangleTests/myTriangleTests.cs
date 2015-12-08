﻿using System;
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
    }
}
