using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TVNApp.API;
using TVNApp.API.Controllers;
using TVNApp.API.Utils;
using TVNApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TVNApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherHandler wHandler;
        private readonly ClothHandler cHandler;

        public WeatherController()
        {
            this.wHandler = new WeatherHandler();
            this.cHandler = new ClothHandler(wHandler);
        }



        // GET: /<controller>/
        public ViewResult Index()
        {
            MainViewModel model = new MainViewModel();
            model.ClothHandler = cHandler;
            model.ViewModel = new MainModel();
            model.ViewModel.Temp = cHandler.TempC;
            model.ViewModel.Humidity = cHandler.Humidity;
            model.ViewModel.Pressure = cHandler.Pressure;
            return View(model);
        }
    }
}
