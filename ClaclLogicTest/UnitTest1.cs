using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcWinForm;

namespace ClaclLogicTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 2, '+', 3)]
        [DataRow(12, 2, '-', 10)]
        [DataRow(7, 2, '*', 14)]
        [DataRow(6, 2, '/', 3)]
        public void TestCalcWF(double x, double y, char op, double res)
        {
            Form1 target = new Form1();
            PrivateObject obj = new PrivateObject(target);
            Assert.AreEqual(res, obj.Invoke("Calculate", x, y, op));
        }
    }
}
