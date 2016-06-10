using Lesson8.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Wechicle Ferrary = new Wechicle();
            Wechicle Zapor   = new Wechicle("Yellow", 66, 20, false, true);
            Wechicle Honda   = new Wechicle("White", 200);
            Wechicle Lada    = new Wechicle("Violet", 90, 60, false, false);
            Wechicle Tesla   = new Wechicle("Navi Blue", 100);
            
            Wechicle[] car = new Wechicle[5];
            car[0] = Ferrary;
            car[1] = Tesla;
            car[2] = Honda;
            car[3] = Lada;
            car[4] = Zapor;

            BubbleSorter<Wechicle> CarSorter = new BubbleSorter<Wechicle>();
            Wechicle[] sortedCars = CarSorter.Sort(car);
            CarSorter.Print(sortedCars);
            Console.WriteLine("Sorted by bubble, press any  key to continue");
            Console.ReadKey();
            Console.WriteLine("Now sorting by insertion");

            //Wechicle[] car = new Wechicle[5];
            car[1] = Ferrary;
            car[3] = Tesla;
            car[0] = Honda;
            car[2] = Lada;
            car[4] = Zapor;

            insertionSorter<Wechicle> CarInSorter = new insertionSorter<Wechicle>();
            sortedCars = CarInSorter.Sort(car);
            CarInSorter.Print(sortedCars);

            Console.ReadKey();
        }
    }
}
