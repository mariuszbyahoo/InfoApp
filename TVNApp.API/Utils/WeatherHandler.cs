using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVNApp.API.Controllers;

namespace TVNApp.API
{
    public class WeatherHandler
    {
        static string data;
        public MainModel MModel;

        public WeatherHandler(WeatherController controller)
        {
            MModel = new MainModel();
            data = controller.GetData().Value;
            GetTemperature();
        }

        public void GetTemperature()
        {
            JObject jsonObject = JObject.Parse(data);
            JToken jToken = jsonObject["main"];
            MModel.Temp = (double)jToken["temp"];
            MModel.Pressure = (int)jToken["pressure"];
            MModel.Humidity = (int)jToken["humidity"];
            MModel.Temp_max = (double)jToken["temp_max"];
            MModel.Temp_min = (double)jToken["temp_min"];
        }
    }
}
