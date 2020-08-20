using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    public class Tractor : MotorVehicle
    {
        public double TireSize { get; set; }
        public int Wheelbase { get; set; }
        public string Drive { get; set; }

        public Tractor(int id, double engineDisplacement, int weight, string category, string engineType, string color, int numberOfEngines, double tireSize, int wheelbase, string drive) : base(id, engineDisplacement, weight, category, engineType, color, numberOfEngines)
        {
            TireSize = tireSize;
            Wheelbase = wheelbase;
            Drive = drive;
        }
    }
}
