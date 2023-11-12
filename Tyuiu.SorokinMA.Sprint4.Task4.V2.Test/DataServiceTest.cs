using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint4.Task4.V2.Lib;

namespace Tyuiu.SorokinMA.Sprint4.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[,] a = new int[,] { { 1, 2, 1 }, { 2, 1, 2 }, { 1, 2, 1 } };
            DataService ds = new DataService();
            int[,] res = ds.Calculate(a);
            int[,] wait = new int[,] { { 0, 2, 0 }, { 2, 0, 2 }, { 0, 2, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
