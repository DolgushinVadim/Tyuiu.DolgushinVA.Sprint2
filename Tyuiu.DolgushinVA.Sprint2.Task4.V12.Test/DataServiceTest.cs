using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint2.Task4.V12.Lib;
namespace Tyuiu.DolgushinVA.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 1;
            double res = ds.Calculate(x,y);
            double wait = 59049;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 2.679;
            Assert.AreEqual(wait, res);
        }
    }
}
