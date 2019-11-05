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
        ClothHandler ClothHandler;

        [HttpGet(Name = "News")]
        [Route("home")]
        public ViewResult Index()
        {
            ArticlesViewModel list = new ArticlesViewModel
            {
                ListViewModel = GetListOfArticles()
            };

            return View(list);
        }

        [HttpGet]
        [Route("temperature")]
        public ActionResult<string> GetTemperature()
        {
            ClothHandler = new ClothHandler(new WeatherHandler(this)); // then calculating an advice

            return Ok(ClothHandler.GetAdvice());
        }

        [HttpGet]
        [Route("news/list")]
        public List<ArticleModel> GetListOfArticles()
        {
            var handler = new XmlHandler();
            var articleList = handler.GetArticles(this);

            return articleList;
        }

        [HttpGet]
        [Route("news/xml")]
        public XmlDocument GetCurrentNews()
        {
            var client = new RestClient("http://www.tvn24.pl/najnowsze.xml");
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response.Content);

            return doc;
        }
    }
}
