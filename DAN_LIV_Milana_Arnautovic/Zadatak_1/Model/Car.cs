using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    public class Car : MotorVehicle
    {
        public string Registration { get; set; }
        public int NumberOfDoors { get; set; }
        public int TankVolume { get; set; }
        public string TransmissionType { get; set; }
        public string Maker { get; set; }
        public int TrafficNumber { get; set; }


        public Car(int id, double engineDisplacement, int weight, string category, string engineType, string color, int numberOfEngines, string registration, int numberOfDoors, int tankVolume, string transmissionType, string maker, int trafficNumber) : base(id, engineDisplacement, weight, category, engineType, color, numberOfEngines)
        {
            Registration = registration;
            NumberOfDoors = numberOfDoors;
            TankVolume = tankVolume;
            TransmissionType = transmissionType;
            Maker = maker;
            TrafficNumber = trafficNumber;
        }
    }
}
