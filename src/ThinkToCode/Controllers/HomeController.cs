using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ThinkToCode.Common.Entity;
using ThinkToCode.Common.Enumeration;
using ThinkToCode.Services.Contract;

namespace ThinkToCode.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// The article service
        /// </summary>
        private IArticleService articleService;
        private IMetatagService metatagService;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="articleService">The article service.</param>
        public HomeController(IArticleService articleService, IMetatagService metatagService, ILogger<HomeController> logger)
        {
            this.logger = logger;
            this.articleService = articleService;
            this.metatagService = metatagService;
        }

        public IActionResult Index()
        {
            var articleSummaries = this.articleService.GetAllArticleSummary(null);
            this.ConfigureMetatagsForSeo();
            return View(articleSummaries);
        }

        [HttpGet]
        public IActionResult Topic(string id)
        {
            var articleSummaries = this.articleService.GetAllArticleSummary(id);
            this.ConfigureMetatagsForSeo();
            return View("Index", articleSummaries);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        private void ConfigureMetatagsForSeo()
        {
            var metatagsInformation = this.metatagService.GetMetatagsForIndexPage();
            ViewData["keywords"] = metatagsInformation.Keywords;
            ViewData["description"] = metatagsInformation.Description;
            ViewData["author"] = metatagsInformation.Author;
            ViewData["url"] = metatagsInformation.Url;
            ViewData["copyright"] = metatagsInformation.Copyright;
            ViewData["robots"] = metatagsInformation.Robots;
        }
    }
}
