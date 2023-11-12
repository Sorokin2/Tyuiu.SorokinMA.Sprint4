using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint4.Task7.V10.Lib;

namespace Tyuiu.SorokinMA.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int a = 3, b = 3;
            string c = "123456789";
            Assert.AreEqual(25, ds.Calculate(a, b, c));
        }
    }
}
