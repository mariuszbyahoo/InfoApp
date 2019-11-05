using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using TVNApp.API.Controllers;
using TVNApp.API.Models;

namespace TVNApp.API.Utils
{
    public class XmlHandler
    {
        public List<ArticleModel> GetArticles()
        {
            var client = new RestClient("http://www.tvn24.pl/najnowsze.xml");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response.Content);
            var node = doc.DocumentElement["channel"];

            var itemNodes = node.SelectNodes("item");
            var list = new List<ArticleModel>();
            var articleCount = 1;

            foreach (XmlNode item in itemNodes)
            {
                var article = new ArticleModel
                {
                    ID = articleCount
                };
                articleCount++;
                article.Title = item.SelectSingleNode("title").InnerText;
                article.Content = Regex.Replace(item.SelectSingleNode("description").InnerText, "<.*?>", String.Empty); 
                // Regular Expression used to delete every html code inside of the node's innerText
                
                article.Link = item.SelectSingleNode("link").InnerText;
                article.PublicationDate = Convert.ToDateTime(item.SelectSingleNode("pubDate").InnerText);

                list.Add(article);
            }

            return list;

        }
    }
}
