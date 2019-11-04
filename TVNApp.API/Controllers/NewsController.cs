using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace TVNApp.API.Controllers
{
    [ApiController]
    public class NewsController : ControllerBase
    {
        [HttpGet]
        [Route("api/news")]
        public ActionResult GetCurrentNews()
        {
            var client = new RestClient("http://www.tvn24.pl/najnowsze.xml");
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);

            return Ok(response.Content);
        }
    }
}
