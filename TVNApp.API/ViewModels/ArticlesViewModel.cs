using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVNApp.API.Models;

namespace TVNApp.ViewModels
{
    public class ArticlesViewModel
    {
        public IEnumerable<ArticleModel> ListViewModel { get; set; } // to jest nullem w Index.cshtml
    }
}
