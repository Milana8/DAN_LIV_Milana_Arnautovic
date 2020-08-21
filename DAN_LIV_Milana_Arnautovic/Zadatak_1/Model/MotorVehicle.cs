using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    /// <summary>
    /// Abstract class motor vehicles
    /// </summary>
    public abstract class MotorVehicle
    {
        public int Id { get; set; }
        public double EngineDisplacement { get; set; }
        public int Weight { get; set; }
        public string Category { get; set; }
        public string EngineType { get; set; }
        public string Color { get; set; }
        public int NumberOfEngines { get; set; }

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
        protected MotorVehicle(int id, double engineDisplacement, int weight, string category, string engineType, string color, int numberOfEngines)
        {
            Id = id;
            EngineDisplacement = engineDisplacement;
            Weight = weight;
            Category = category;
            EngineType = engineType;
            Color = color;
            NumberOfEngines = numberOfEngines;
        }
        /// <summary>
        /// Abstract method Start
        /// </summary>
        /// <param name="o"></param>
        public abstract void Start(object o);

        /// <summary>
        /// Abstract method Stop
        /// </summary>
        /// <param name="o"></param>
        public abstract void Stop(object o);
    }
}
