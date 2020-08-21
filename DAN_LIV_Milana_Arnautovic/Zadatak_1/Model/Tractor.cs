using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    /// <summary>
    /// Class Tractor
    /// </summary>
    public class Tractor : MotorVehicle
    {
        public double TireSize { get; set; }
        public int Wheelbase { get; set; }
        public string Drive { get; set; }
        /// <summary>
        /// Constructor whit parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="engineDisplacement"></param>
        /// <param name="weight"></param>
        /// <param name="category"></param>
        /// <param name="engineType"></param>
        /// <param name="color"></param>
        /// <param name="numberOfEngines"></param>
        /// <param name="tireSize"></param>
        /// <param name="wheelbase"></param>
        /// <param name="drive"></param>
        public Tractor(int id, double engineDisplacement, int weight, string category, string engineType, string color, int numberOfEngines, double tireSize, int wheelbase, string drive) : base(id, engineDisplacement, weight, category, engineType, color, numberOfEngines)
        {
            TireSize = tireSize;
            Wheelbase = wheelbase;
            Drive = drive;
        }
        public override void Start(object o)
        {
            Tractor tractor = (Tractor)o;
            Console.WriteLine(tractor.Color + " tractor started.");
        }
        public override void Stop(object o)
        {
            Tractor tractor = (Tractor)o;
            Console.WriteLine(tractor.Color + " tractor stopped.");

        }
    }
}
