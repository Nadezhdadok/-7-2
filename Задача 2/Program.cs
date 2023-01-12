using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
class Program
    {
        static void GetParamsCube(double l, out double s, out double v)
        {
            s = 6 * l * l;
            v = l * l * l;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double l = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsCube(l, out s, out v);
            Console.WriteLine("Площадь и объем куба будут равны:");
            Console.WriteLine("{0:.00} {1}", s, v);
        }
    }
}
