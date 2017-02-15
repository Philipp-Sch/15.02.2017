using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._02._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations cal = new Calculations();
            Console.Write(cal.Calculate(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}