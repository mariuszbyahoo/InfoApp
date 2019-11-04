using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVNApp.API;
using TVNApp.API.Utils;

namespace TVNApp.ViewModels
{
    public class MainViewModel
    {
        public MainModel ViewModel { get; set; }
        public ClothHandler ClothHandler { get; set; }
    }
}
