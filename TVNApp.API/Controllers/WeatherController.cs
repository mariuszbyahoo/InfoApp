//using Microsoft.AspNetCore.Mvc;
//using RestSharp;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TVNApp.API.Utils;

//namespace TVNApp.API.Controllers
//{
//    [ApiController]
//    public class WeatherController : ControllerBase
//    {

//        WeatherHandler WeatherHandler; 
//        ClothHandler ClothHandler;

//        [HttpGet]
//        [Route("api/weather")]
//        public ActionResult<string> GetData()
//        {
//            var client = new RestClient("http://api.openweathermap.org/data/2.5/weather?q=Warsaw,pl&APPID=bcb0c61841c80cc665a6cec5e9fbd83c");
//            var request = new RestRequest(Method.GET);

//            var response = client.Execute(request);

//            return response.Content;
//        }

//        [HttpGet]
//        [Route("temperature")]
//        public ActionResult<string> GetTemperature()
//        {
//            WeatherHandler = new WeatherHandler(this); // creating weatherHandler, he's doing its job

//            ClothHandler = new ClothHandler(); // then calculating an advice

//            return Ok(ClothHandler.getAdvice(WeatherHandler));
//        }
//    }
//}
