using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    /// <summary>
    /// Class Car
    /// </summary>
    public class Car : MotorVehicle
    {
        public string Registration { get; set; }
        public int NumberOfDoors { get; set; }
        public int TankVolume { get; set; }
        public string TransmissionType { get; set; }
        public string Maker { get; set; }
        public int TrafficNumber { get; set; }


        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="engineDisplacement"></param>
        /// <param name="weight"></param>
        /// <param name="category"></param>
        /// <param name="engineType"></param>
        /// <param name="color"></param>
        /// <param name="numberOfEngines"></param>
        /// <param name="registration"></param>
        /// <param name="numberOfDoors"></param>
        /// <param name="tankVolume"></param>
        /// <param name="transmissionType"></param>
        /// <param name="maker"></param>
        /// <param name="trafficNumber"></param>
        public Car(int id, double engineDisplacement, int weight, string category, string engineType, string color, int numberOfEngines, string registration, int numberOfDoors, int tankVolume, string transmissionType, string maker, int trafficNumber) : base(id, engineDisplacement, weight, category, engineType, color, numberOfEngines)
        {
            Registration = registration;
            NumberOfDoors = numberOfDoors;
            TankVolume = tankVolume;
            TransmissionType = transmissionType;
            Maker = maker;
            TrafficNumber = trafficNumber;
        }
        /// <summary>
        /// Overridden Start method
        /// </summary>
        /// <param name="o"></param>
        public override void Start(object o)
        {
            Car car = (Car)o;
            Console.Write(car.Color + " " + car.Maker + " started.\t");

        }
        /// <summary>
        /// Overridden Stop method
        /// </summary>
        /// <param name="o"></param>
        public override void Stop(object o)
        {
            Car car = (Car)o;
            Console.Write(car.Color + " " + car.Maker + " stopped.");

        }
        /// <summary>
        /// A method to change the color of a car
        /// </summary>
        /// <param name="color"></param>
        /// <param name="trafficNumber"></param>
        public void ChangeColor(string color, int trafficNumber)
        {
            Color = color;
            TrafficNumber = trafficNumber;
        }
        public static List<Car> cars = new List<Car>();
        static AutoResetEvent auto = new AutoResetEvent(false);
        static object l = new object();
        static Random rnd = new Random();

        /// <summary>
        ///  Car race method
        /// </summary>
        /// <param name="o"></param>
        public void CarRace(object o)
        {
            Car car = (Car)o;
            Stopwatch stop1 = new Stopwatch();
            Stopwatch stop2 = new Stopwatch();
            Stopwatch stop3 = new Stopwatch();
            Start(car);
            stop1.Start();
            while (stop1.ElapsedMilliseconds < 10001)
            {

                if (car.TankVolume > 0)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(car.Color + " " + car.Maker + " moving towards the goal");

                    car.TankVolume -= rnd.Next(2, 4);

                }
                else
                {
                    Console.WriteLine(car.Color + " " + car.Maker + " ran out of fuel and unfortunately ends the race.");
                    return;
                }
            }
            stop1.Stop();
            if (auto.WaitOne())
            {
                Console.Write("\tThe traffic light is red. Please wait. \t");
                car.Stop(car);

            }
            Console.Write("The traffic light is green .Go!\n");
            stop2.Start();

            while (stop2.ElapsedMilliseconds < 3001)
            {
                Thread.Sleep(1000);
                Console.WriteLine(car.Color + " " + car.Maker + " moving towards the goal");
                car.TankVolume -= rnd.Next(2, 4);
            }
            stop2.Stop();


            if (car.TankVolume < 15)
            {
                // Only one car can refuel

                lock (l)
                {
                    Console.WriteLine(car.Color + " " + car.Maker + " stops at a gas station");
                    Console.WriteLine(car.Color + " " + car.Maker + " refueled");
                    car.TankVolume = 100;

                }
            }
            stop3.Start();

            while (stop3.ElapsedMilliseconds < 7001)
            {
                if (car.TankVolume > 0)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(car.Color + " " + car.Maker + " moving towards the goal");
                    car.TankVolume -= rnd.Next(2, 4);
                }
                else
                {
                    Console.WriteLine(car.Color + " " + car.Maker + " ran out of fuel and unfortunately ends the race.");
                    return;
                }
            }
            stop3.Stop();
            
            Console.WriteLine(car.Color + " " + car.Maker + " finished the race!");
            
            
        }
           
        /// <summary>
        /// Traffic light method 
        /// </summary>
        public static void TrafficLight()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            while (s.ElapsedMilliseconds < 22000)
            {
                Thread.Sleep(2000);
                auto.Set();

                Thread.Sleep(2000);
                auto.Reset();
            }
            s.Stop();
        }

    }
}


