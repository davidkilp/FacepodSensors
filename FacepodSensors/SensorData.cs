using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacepodSensors
{
    internal class SensorData
    {
        public required DateTime Date { get; set; }
        public required double Power { get; set; }
        public required double BusVoltage { get; set; }
        public required double Current { get; set; }
        public required double TemperatureTop { get; set; }
        public required double TemperatureCPU { get; set; }
        public int Sales { get; set; }
    }
}
