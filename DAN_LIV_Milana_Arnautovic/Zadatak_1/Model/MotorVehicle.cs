using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    public abstract class MotorVehicle
    {
        public int Id { get; set; }
        public double EngineDisplacement { get; set; }
        public int Weight { get; set; }
        public string Category { get; set; }
        public string EngineType { get; set; }
        public string Color { get; set; }
        public int NumberOfEngines { get; set; }

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

    }
}
