using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Printer
    {
        public static void Print(IPlant plant)
        {
            Console.WriteLine("---------------");
            Console.WriteLine(plant.ToString());
        }

        public static void IsObjectOfClass(object obj, Type type)
        {
            if(obj.GetType() == type)
            {
                Console.WriteLine("Тип объекта совпадает с указанным");
            }
            else
            {
                Console.WriteLine("Тип объекта не совпадает с указанным. Тип объекта:" + obj.GetType());
            }
        }

        public static void Print(object obj)
        {

            IPlant plant = obj as IPlant;
            if(plant as IPlant != null)
            {
                Print(plant);
            }
            else
            {
                Console.WriteLine("---------------Print for " + obj.GetType() + "---------------");
                Console.WriteLine(obj.ToString());
            }
            
        }

    }
}
