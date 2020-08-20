using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1.Model;

namespace Zadatak_1
{
    class Program
    {
        public static List<Car> cars = new List<Car>();
        public static Stack<Tractor> tractors = new Stack<Tractor>();
        public static Queue<Truck> trucks = new Queue<Truck>();

        static void Main(string[] args)
        {
            Car car1 = new Car(1, 40.4, 300, "B", "benzin", "crvena", 123, "NS-999-MM", 3, 20, "mehanicka", "ford", 333);
            Car car2 = new Car(2, 44.4, 340, "B", "benzin", "plava", 321, "NS-000-MM", 5, 24, "mehanicka", "audi", 444);
            cars.Add(car1);
            cars.Add(car2);

            Tractor tractor1 = new Tractor(3, 50, 700, "F", "benzin", "crvena", 777, 78.8, 7, "dvoosovinski");
            Tractor tractor2 = new Tractor(4, 70, 1200, "F", "benzin", "zelena", 888, 98.8, 9, "dvoosovinski");
            tractors.Push(tractor1);
            tractors.Push(tractor2);

            Truck truck1 = new Truck(5, 100, 2000, "C", "benzin", "siva", 987, 1500, 40, 3);
            Truck truck2 = new Truck(6, 122, 2222, "C", "benzin", "bela", 851, 1800, 50, 5);
            trucks.Enqueue(truck1);
            trucks.Enqueue(truck2);
        }
    }
}
