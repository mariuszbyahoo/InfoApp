using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using TVNApp.API.Models;
using TVNApp.API.Utils;
using TVNApp.ViewModels;

namespace TVNApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : Controller
    {

        [HttpGet(Name = "News")]
        [Route("home")]
        public ViewResult Index()
        {
            var handler = new XmlHandler();
            var articleList = handler.GetArticles();

            ArticlesViewModel list = new ArticlesViewModel
            {
                ListViewModel = articleList
            };

            return View(list);
        }
    }
}
