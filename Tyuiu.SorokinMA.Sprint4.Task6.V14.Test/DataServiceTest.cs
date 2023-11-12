using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint4.Task6.V14.Lib;

namespace Tyuiu.SorokinMA.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            string[] a = new string[] { "asdf", "asdf", "asd", "asd" };
            string[] wait = new string[] { "asdf", "asdf" };
            DataService ds = new DataService();
            CollectionAssert.AreEqual(wait, ds.Calculate(a));
        }
    }
}
