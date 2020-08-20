using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    public class Truck : MotorVehicle
    {
        public double LoadCapacity { get; set; }
        public double Height { get; set; }
        public int NumberOfSeats { get; set; }

        public Truck(int id, double engineDisplacement, int weight, string category, string engineType, string color, int numberOfEngines, double loadCapacity, double height, int numberOfSeats) : base(id, engineDisplacement, weight, category, engineType, color, numberOfEngines)
        {
            LoadCapacity = loadCapacity;
            Height = height;
            NumberOfSeats = numberOfSeats;
        }
    }
}
