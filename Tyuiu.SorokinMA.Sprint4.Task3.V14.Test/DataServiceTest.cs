using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint4.Task3.V14.Lib;

namespace Tyuiu.SorokinMA.Sprint4.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[,] a = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 }, { 3, 4, 5 }, { 1, 1, 1 } };
            DataService ds = new DataService();
            int res = ds.Calculate(a);
            Assert.AreEqual(5, res);

        }
    }
}
