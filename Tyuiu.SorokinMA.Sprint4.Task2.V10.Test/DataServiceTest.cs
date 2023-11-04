using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint4.Task2.V10.Lib;

namespace Tyuiu.SorokinMA.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[] a = new[] { 1, 2, 3, 4, 5 };
            DataService ds = new DataService();
            int res = ds.Calculate(a);
            Assert.AreEqual(15, res);
        }
    }
}
