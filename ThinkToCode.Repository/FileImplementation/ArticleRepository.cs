using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity;
using ThinkToCode.Common.Enumeration;
using ThinkToCode.Repository.Common;
using ThinkToCode.Repository.Contract;
using ThinkToCode.Repository.DbData;

namespace ThinkToCode.Repository.FileImplementation
{
    public class ArticleRepository : Common.BaseRepository<ArticleEntity>, IArticleRepository
    {
        ArticleDataTable articleData;

        public ArticleRepository()
        {
            articleData = ArticleDataTable.Instance;
        }


        public ArticleSummary GetArticlesBySeoTitle(string seoTitle)
        {
            var article = this.articleData.PopulateArticles().Where(x => string.Compare(x.SeoTitle, seoTitle, true) == 0).First();
            return new ArticleSummary { FileName = string.Format("{0}.cshtml", article.FileKey) };
        }

        public IList<ArticleSummary> GetArticlesSnapShots(string category)
        {
            HashSet<int> topicIds = new HashSet<int>();
            var articleSummaries = new List<ArticleSummary>();
            IList<ArticleEntity> articleEntities = new List<ArticleEntity>();
            articleEntities = this.articleData.PopulateArticles();

            if (!string.IsNullOrEmpty(category))
            {
                var menuItem = MenuDataTable.Instance.PopulateMenu();

                var menu = menuItem.Menus.Where(x => string.Equals(x.UrlNameOrDefault, category, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (menu != null)
                {
                    topicIds = new HashSet<int>(menuItem.SubMenuMappings.Where(x => x.MenuId == menu.Id).Select(x => x.SubMenuId));
                }
                else
                {
                    menu = menuItem.SubMenus.Where(x => string.Equals(x.UrlNameOrDefault, category, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                    if (menu != null)
                    {
                        topicIds.Add(menu.Id);
                    }
                }
            }


            if (topicIds.Any())
            {
                articleEntities = articleEntities.Where(X => topicIds.Contains(X.TopicId)).ToList();
            }

            foreach (var article in articleEntities)
            {
                articleSummaries.Add(new ArticleSummary
                {
                    Id = article.Id,
                    WrittenOn = article.WrittenOn,
                    Tile = article.Tile,
                    SeoTitle = article.SeoTitle,
                    Description = article.Description
                });
            }

            return articleSummaries;
        }

        /// <summary>
        /// Gets the dummy data for article sumaries.
        /// </summary>
        /// <returns>
        /// Return list of article with summary
        /// </returns>      
        //private IList<ArticleSummary> GetDummyDataForArticleSumaries()
        //{
        //    var articles = new List<ArticleSummary>();
        //    articles.Add(new ArticleSummary
        //    {
        //        Tile = "Visitor Pattern - ReExplained !!",
        //        SeoTitle = "Visitor-Pattern-ReExplained",
        //        WrittenOn = "March 17, 2018",
        //        //ArticleType = (int)ArticleTypeEnum.DesingArchitecture,
        //        Summary = "Visitor Pattern is, in general opinion, is the most complicated design pattern because of the nature of problem it solves. We will look what it is, how it works and how it should be implemented in real scenarios.<o:p>" +
        //        "Every one among us might get into the situation, when we have a complex class hierarchy and we want to add or modify their behaviors without changing their original code.The “Complex” word I have used because in the hierarchy, every object are of different types and we want to add operation which will run on specific type’s.i.e.different operation for different types of object. Frankly saying, most of time we do type/instance checking to determine the type and then select the operation via If-else statement.This approach has its own limitations and, of course, not an object oriented way.To fix this type of problems in an object oriented way – Visitor Pattern came into picture."
        //    });

        //    return articles;
        //}

    }
}
