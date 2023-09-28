using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KarpenkoNA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.KarpenkoNA.Sprint1.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string buk = 'нн';
            Console.WriteLine("Введите: ");
            string str = Console.ReadLine();
            string res = ds.CheckDoubleN(str);
            var arr = res.Split();

            foreach (var word in arr)
            {
                if (word == buk)
                {
                    Console.WriteLine("Найдено слово: " + word);
                }
            }

            Console.WriteLine(ds.CheckDoubleN(str));

            Console.ReadKey();
        }
    }
}
