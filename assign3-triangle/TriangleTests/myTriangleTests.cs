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
    }
}
