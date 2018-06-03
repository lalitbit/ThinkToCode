using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ThinkToCode.Common.Entity;
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
            var articleSummaries = this.articleService.GetAllArticleSummary();
            this.ConfigureMetatagsForSeo();
            return View(articleSummaries);
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

        private IList<ArticleSummary> GetDummyDataForArticleSumaries()
        {
            var articles = new List<ArticleSummary>();
            articles.Add(new ArticleSummary
            {
                Tile = "Visitor Pattern - ReExplained !!",
                SeoTitle = "Visitor-Pattern-ReExplained",
                WrittenOn = "March 17, 2018",
                ArticleType = (int)ArticleTypeEnum.DesingArchitecture,
                Summary = "Visitor Pattern is, in general opinion, is the most complicated design pattern because of the nature of problem it solves. We will look what it is, how it works and how it should be implemented in real scenarios.<o:p>" +
                "Every one among us might get into the situation, when we have a complex class hierarchy and we want to add or modify their behaviors without changing their original code.The “Complex” word I have used because in the hierarchy, every object are of different types and we want to add operation which will run on specific type’s.i.e.different operation for different types of object. Frankly saying, most of time we do type/instance checking to determine the type and then select the operation via If-else statement.This approach has its own limitations and, of course, not an object oriented way.To fix this type of problems in an object oriented way – Visitor Pattern came into picture."
            });

            return articles;
        }

    }
}
