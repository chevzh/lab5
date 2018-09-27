using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cactus cact = new Cactus();
            Rose rose = new Rose();
            Bush b = new Bush() {rose,cact};

            Bouqet bouqet = new Bouqet(b) { new Cactus()};

            IPlant plant = new Rose();

            rose.Grow();
            ((IPlant)rose).Grow();

            rose.Name = "Роза";
            rose.Color = "Red";
            

            foreach(var flower in bouqet)
            {
                Printer.Print(flower);
            }
        }
    }
}
