using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint2.Task7.V9.Lib;
namespace Tyuiu.DolgushinVA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.262;
            double y = 0.25;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
