using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint2.Task5.V11.Lib;
namespace Tyuiu.DolgushinVA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 1917;
            int m = 4;
            int n = 8;
            string res = ds.FindDateOfNextDay(g,m,n);
            string wait = "09.04.1917";
            Assert.AreEqual(wait, res);
        }
    }
}
