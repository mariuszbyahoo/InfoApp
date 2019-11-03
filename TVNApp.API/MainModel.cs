using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVNApp.API
{
    public class MainModel
    {
        public double Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }
        private double amplitude;

        public override string ToString()
        {
            amplitude = Temp_max - Temp_min;
            return $"Current temperature: {Temp}\nAir Humidity: {Humidity}\nPressure: {Pressure}\nForecasted temperature amplitude: {amplitude}";
        }
    }
}
