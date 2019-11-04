using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using TVNApp.API.Models;
using TVNApp.API.Utils;

namespace TVNApp.API.Controllers
{
    [ApiController]
    public class NewsController : ControllerBase
    {
        [HttpGet]
        [Route("api/news")]
        public XmlDocument GetCurrentNews()
        {
            var client = new RestClient("http://www.tvn24.pl/najnowsze.xml");
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response.Content);

            return doc;
        }

        [HttpGet]
        [Route("news")]
        public ActionResult<string> GetArticleTitle()
        {
            var handler = new XmlHandler();
            var articleList = handler.GetArticles(this);
            var info = "";

            foreach (var model in articleList)
            {
                info += model.ToString();
            }
            return Ok(info);
        }
    }
}
