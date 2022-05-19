using System;
using shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace shapetest
{
    [TestClass]
    public class circletest
    {
    
        [TestMethod]
        public void areareturn314()
        {
            double a = 10;
            double expected = 314.1592653589793;
            Circle circle = new Circle(a);
            double actual = circle.Area;
            Assert.AreEqual(expected, actual);
        }
  
        [TestMethod]
        public void returnneotric()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-50));
        }
    }
}
