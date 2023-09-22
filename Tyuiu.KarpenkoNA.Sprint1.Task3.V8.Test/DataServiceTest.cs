using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.KarpenkoNA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 20.0;
            double y = 30.0;
            double vklad = 2541.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(vklad, res);

        }
    }
}
