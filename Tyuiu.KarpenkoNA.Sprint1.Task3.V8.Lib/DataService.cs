using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarpenkoNA.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double a, double b)
        {
            return 2500 + (((2500 * (a / 100)) / 365) * b);
        }
    }
}
