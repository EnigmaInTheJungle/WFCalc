using System;
using CalcWFwithButtons;
using CalcWPFwithButtons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLogicTestsWPFnWF
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 2, '+', 3)]
        [DataRow(12, 2, '-', 10)]
        [DataRow(7, 2, '*', 14)]
        [DataRow(6, 2, '/', 3)]
        public void TestCalcWPF(int x, int y, char op, int res)
        {
            MainWindow target = new MainWindow();
            PrivateObject obj = new PrivateObject(target);
            Assert.AreEqual(res, obj.Invoke("Calculate", x, y, op));
        }

        [DataTestMethod]
        [DataRow(1, 2, '+', 3)]
        [DataRow(12, 2, '-', 10)]
        [DataRow(7, 2, '*', 14)]
        [DataRow(6, 2, '/', 3)]
        public void TestCalcWF(int x, int y, char op, int res)
        {
            Form1 target = new Form1();
            PrivateObject obj = new PrivateObject(target);
            Assert.AreEqual(res, obj.Invoke("Calculate", x, y, op));
        }
    }
}
