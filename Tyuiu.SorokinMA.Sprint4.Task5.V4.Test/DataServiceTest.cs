using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint4.Task5.V4.Lib;

namespace Tyuiu.SorokinMA.Sprint4.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] a = new int[,] { { -4, -3, -2 }, { -1, 1, 2 }, { 3, 4, 5 } };
            DataService ds = new DataService();
            int res = ds.Calculate(a);
            Assert.AreEqual(5, res);
        }
    }
}
