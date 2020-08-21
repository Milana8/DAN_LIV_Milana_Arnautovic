using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Zadatak_1.Model;

namespace Zadatak_1
{
    class Program
    {
        private static int seconds = 6;
        public static List<Car> cars = new List<Car>();
        public static Stack<Tractor> tractors = new Stack<Tractor>();
        public static Queue<Truck> trucks = new Queue<Truck>();
        static Random rnd = new Random();
               
        /// <summary>
        /// A method that puts cars at the start
        /// </summary>
        /// <param name="o"></param>
        public static void Preparation(object o)
        {
            Car car = (Car)o;
            Console.Write(car.Color + " " + car.Maker + " in position.\t ");
        }
        /// <summary>
        /// Stopwatch counting down 5 seconds
        /// </summary>
        public static void Tick()
        {
            while (seconds > 0)
            {
                Thread.Sleep(1000);
                seconds--;
                Console.WriteLine("********** " + seconds + " **********");
            }
        }
        

        static void Main(string[] args)

        {
            Car car1 = new Car(1, 40.4, 300, "B", "benzin", "Red", 123, "NS-999-MM", 3, 50, "mehanicka", "ford", rnd.Next(1000, 9000));
            Car car2 = new Car(2, 44.4, 340, "B", "benzin", "Blue", 321, "NS-000-MM", 5, 20, "mehanicka", "audi", rnd.Next(1000, 9000));
            cars.Add(car1);
            cars.Add(car2);

            Tractor tractor1 = new Tractor(3, 50, 700, "F", "benzin", "red", 777, 78.8, 7, "dvoosovinski");
            Tractor tractor2 = new Tractor(4, 70, 1200, "F", "benzin", "green", 888, 98.8, 9, "dvoosovinski");
            tractors.Push(tractor1);
            tractors.Push(tractor2);

            Truck truck1 = new Truck(5, 100, 2000, "C", "benzin", "grey", 987, 1500, 40, 3);
            Truck truck2 = new Truck(6, 122, 2222, "C", "benzin", "white", 851, 1800, 50, 5);
            trucks.Enqueue(truck1);
            trucks.Enqueue(truck2);
            
            car2.ChangeColor("Green", rnd.Next(1000, 9000)); //Car color change

            Tick();
            Console.Clear();

            //Creating and starting threads
            for (int i = 0; i < cars.Count; i++)
            {
                int temp = i;
                Thread t = new Thread(() => Preparation(cars[temp]));
                t.Start(); t.Join();

            }
            Car golf = new Car(1, 40.4, 300, "B", "benzin", "Orange", 123, "NS-999-MM", 3, 30, "mehanicka", "golf", rnd.Next(1000, 9000));
            cars.Add(golf);
            Console.WriteLine("\nJoins orange golf");

            //Creating and starting threads
            for (int i = 0; i < cars.Count; i++)
            {
                int temp = i;
                Thread t = new Thread(() => cars[temp].CarRace(cars[temp]));
                t.Start();

            }

            Thread semaphore = new Thread(() => Car.TrafficLight()); //Creating thread
                       
            semaphore.Start(); // Start thread
            Console.ReadLine();

        }
    }
}

