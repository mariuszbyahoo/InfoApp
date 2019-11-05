using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;
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

        public WeatherHandler()
        {
            var client = new RestClient("http://api.openweathermap.org/data/2.5/weather?q=Warsaw,pl&APPID=bcb0c61841c80cc665a6cec5e9fbd83c");
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);
            MModel = new MainModel();
            data = response.Content;
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
