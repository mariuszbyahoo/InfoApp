using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVNApp.API.Controllers;

namespace TVNApp.API.Utils
{
    public class ClothHandler
    {
        private string tShirt = "T-Shirt";
        private string shorts = "Shorts";
        private string jeans = "Jeans";
        private string lightJacket = "Light, leather jacket or pullover";
        private string stichedJacket = "Stitched jacket";
        private string winterJacket = "Winter jacket";
        private string woolCoat = "Thick, wool coat";
        private string flipFlops = "Flip-flops";
        private string sneakers = "sneakers";
        private string winterBoots = "Winter Boots";
        public double TempK;
        public int TempC;
        public int Humidity;
        public int Pressure;

        public ClothHandler(WeatherHandler handler)
        {
            TempK = handler.MModel.Temp;
            Humidity = handler.MModel.Humidity;
            Pressure = handler.MModel.Pressure;
            TempC = (int)TempK - 273;
        }

        public string GetAdvice ()
        {
            //var tempK = handler.MModel.Temp; 
            //var tempC = (int)tempK - 273;
            var info = "In order to have a lovely walk you have to wear: ";
            info = AppendInfo(info, TempK);
            info += $"\nBecause, the current temperature is: {TempC} *C"; 

            return info;
        }

        private string AppendInfo (string info, double tempK)
        {
            if (tempK > 298)
            {
                info += $"{tShirt}, {shorts}, and {flipFlops}";
            }
            else if (tempK > 283 && tempK < 298)
            {
                info += $"{lightJacket}, {jeans}, and {sneakers}";
            }
            else if (tempK > 277 && tempK < 283)
            {
                info += $"{stichedJacket}, {jeans}, and {sneakers}";
            }
            else if (tempK > 268 && tempK < 277)
            {
                info += $"{winterJacket}, {jeans}, and {winterBoots}";
            }
            else if (tempK < 268)
            {
                info += $"{woolCoat}, {jeans}, and {winterBoots}";
            }
            else
            {
                info = "something went wrong";
            }

            return info;
        }
    }
}
