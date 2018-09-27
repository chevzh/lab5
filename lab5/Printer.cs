using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    static class Printer
    {
        public static void Print(IPlant plant)
        {
            Console.WriteLine("---------------");
            Console.WriteLine(plant.ToString());
        }

    }
}
