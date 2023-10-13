using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint2.Task6.V9.Lib;
namespace Tyuiu.DolgushinVA.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int m = 4;
            int n = 8;
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "09.04";
            Assert.AreEqual(wait, res);
        }
    }
}
