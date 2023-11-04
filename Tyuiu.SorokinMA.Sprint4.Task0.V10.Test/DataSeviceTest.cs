using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint4.Task0.V10.Lib;

namespace Tyuiu.SorokinMA.Sprint4.Task0.V10.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] a = new[] { 3, 4, 5, 4, 2, 2, 2, 2, 3, 5 };
            int res = ds.GetSumOddArrEl(a);
            Assert.AreEqual(16, res);
        }
    }
}
