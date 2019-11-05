using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVNApp.API.Models
{
    public class ArticleModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Content { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
