using System;
using shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace shapetest
{
    [TestClass]
    public class triangletest
    {
        [TestMethod]
        public void areareturn6()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
       
            triangle triangle = new triangle(a, b, c);
            double actual = triangle.Area;
     
            Assert.AreEqual(expected, actual);
        }

        // тест на прямоугольный треугольник
        [TestMethod]
        public void areareturntrue()
        {
          
            double a = 16;
            double b = 30;
            double c = 34;
            bool expected = true;

            triangle triangle = new triangle(a, b, c);
            bool actual = triangle.rightrian;
         
            Assert.AreEqual(expected, actual);
        }
    }
}