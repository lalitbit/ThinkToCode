
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ThinkToCode.Services.Contract;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ThinkToCode.Controllers
{
    public class ArticleController : Controller
    {
        private IHostingEnvironment _env;
        private IMetatagService metatagService;

        public ArticleController(IHostingEnvironment env, IMetatagService metatagService)
        {
            _env = env;
            this.metatagService = metatagService;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(string id)
        {
            var file = Path.Combine(_env.WebRootPath, "content", "Visitor-Pattern-Reexplained.cshtml");
            this.ConfigureMetatagsForSeo(id);
            return View("index", file);
        }

        /// <summary>
        /// Configures the metatags for seo.
        /// </summary>
        /// <param name="information">The information.</param>
        private void ConfigureMetatagsForSeo(string information)
        {
            //
            var info = information.Replace('-',' ') + ",";
            var metatagsInformation = this.metatagService.GetMetatagsForIndexPage();
            ViewData["keywords"] = info +  metatagsInformation.Keywords;
            ViewData["description"] = info + metatagsInformation.Description;
            ViewData["author"] = metatagsInformation.Author;
            ViewData["url"] = metatagsInformation.Url;
            ViewData["copyright"] = metatagsInformation.Copyright;
            ViewData["robots"] = metatagsInformation.Robots;
        }

    }
}
