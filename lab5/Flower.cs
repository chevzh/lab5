using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Flower : IPlant
    {

        public void DoFotosintez()
        {
            Console.WriteLine("Fotosinteziruyu tak skozat'");
        }
        public string Color { get; set; }
        public string Name { get; set; }
    }
}
