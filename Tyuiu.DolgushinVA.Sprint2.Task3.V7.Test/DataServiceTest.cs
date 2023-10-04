using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint2.Task3.V7.Lib;
namespace Tyuiu.DolgushinVA.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Calculate(x);
            var wait = 50;
            Assert.AreEqual(wait, res);
        }
    }
}
