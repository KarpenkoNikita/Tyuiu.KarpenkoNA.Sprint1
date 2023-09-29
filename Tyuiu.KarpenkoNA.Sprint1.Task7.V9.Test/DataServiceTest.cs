using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint1.Task7.V9.Lib;

namespace Tyuiu.KarpenkoNA.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 18.699;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
