using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.KarpenkoNA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Я шел домой растроенный";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest);
            string wait = "растроенный";
            Assert.AreEqual(wait, res);
        }
    }
}
