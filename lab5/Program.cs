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
            Gladiolus gladiolus = new Gladiolus();
            Paper paper = new Paper();
            IPlant plant = new Rose();

            Bush bush = new Bush() { rose, cact };
            Bouqet bouqet = new Bouqet(bush) { new Cactus()};

            Printer printer = new Printer();
            
            //работа с одноимёнными методами
            rose.Grow();
            ((IPlant)rose).Grow();

            Printer.IsObjectOfClass(plant, typeof(IPlant));

            //Работа с объектом Rose через ссылку на интерфейс IPlant
            Printer.Print(plant);

            //Вызывается метод Grow определённый в классе Rose для интерфейса IPlant
            plant.Grow();
            //Вызывается метод Grow() переопределённый в классе Rose(см. класс Flower)
            rose.Bloom();

            //Метод Bloom() нельзя вызвать, т.к. этот метод не определён в интерфейсе(это метод класса Flower)
            //plant.Bloom();
            ((Rose)plant).Bloom();


            Printer.Print(bouqet);

            object[] arr = new object[] { cact, rose, gladiolus, paper, plant, bush, bouqet, printer };
            Console.WriteLine("Вывод информации о всех классах, определённых в лабе");
            
            foreach(var item in arr)
            {
                Printer.Print(item);
            }

        }
    }
}
