using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KarpenkoNA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x = 7500;
            DataService ds = new DataService();
            double res = ds.SecondsToHours(x);

            int result = Convert.ToInt32(res);

            int wait = 2;
            Assert.AreEqual(wait, result);
        }
    }
}
